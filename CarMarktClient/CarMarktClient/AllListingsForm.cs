using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CarMarktClient
{
  public partial class AllListingsForm : Form
  {
    static string[] orderBy = new string[] { "Make", "Year", "Model", "Price", "Body Type", "Fuel Type" };

    public AllListingsForm()
    {
      InitializeComponent();
      SearchByComboBox.DataSource = orderBy;
      DetailsButton.Visible = false;
      Program.shouldExitOnClose = true;
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
      RefreshDataGridView();
    }

    private void DetailsButton_Click(object sender, EventArgs e)
    {
      if (ListingsDataGridView.SelectedRows.Count == 1)
      {
        FullCarData fullCarData = Program.client.ViewListing(new CarCode { Code = uint.Parse(ListingsDataGridView.SelectedRows[0].Cells["Code"].Value.ToString()) });
        if (fullCarData == null || fullCarData.PartialData == null)
        {
          MessageBox.Show("ERROR: Couldn't find car");
        }
        else
        {
          CurrentListingForm listingForm = new CurrentListingForm(fullCarData);
          listingForm.Show();
          Program.shouldExitOnClose = false;
          Close();
        }
      }
      else
      {
        MessageBox.Show("Please select a row");
      }
    }

    private void AddListingButton_Click(object sender, EventArgs e)
    {
      NewListingForm newListingForm = new NewListingForm();
      newListingForm.Show();
      Program.shouldExitOnClose = false;
      Close();
    }

    private void LogOutButton_Click(object sender, EventArgs e)
    {
      Session_Id session = new Session_Id(); session.Id = Program.SessionId;
      Result result = Program.client.Logout(session);
      MessageBox.Show(result.Message);
      Program.SessionId = null;
      Program.Username = null;
      Program.logInForm.Show();
      Program.shouldExitOnClose = false;
      Close();
    }

    private async void RefreshDataGridView()
    {
      ListingsDataGridView.Rows.Clear();
      using (var call = Program.client.RefreshListings(new Empty { }))
      {
        while (await call.ResponseStream.MoveNext())
        {
          PartialCarData data = call.ResponseStream.Current;
          string car = Convert.ToString(data.Year) + " " + data.Make + " " + data.Model;
          ListingsDataGridView.Rows.Add(new object[] { Convert.ToString(data.Code), car, // Code column is hidden for data purposes
            Enum.GetName(typeof(Body), (Body)data.Body), Enum.GetName(typeof(Fuel), (Fuel)data.Fuel), Convert.ToString(data.Price),
            Convert.ToString(data.Year), Convert.ToString(data.Make), Convert.ToString(data.Model) }); // These columns are hidden
        }
      }
      OrderDataGridViewBy("Model");
    }

    private async void RefreshDataGridViewBySearch(string query)
    {
      ListingsDataGridView.Rows.Clear();
      using (var call = Program.client.RefreshListings(new Empty { }))
      {
        while (await call.ResponseStream.MoveNext())
        {
          PartialCarData data = call.ResponseStream.Current;
          bool canAdd = false;
          try
          {
            string s = SearchByComboBox.SelectedItem.ToString();
            switch (s)
            {
              case "Year": try { canAdd = !string.IsNullOrEmpty(query) && data.Year == Convert.ToUInt32(query); } catch { canAdd = false; } break;
              case "Make": canAdd = data.Make.ToLower().Contains(query.ToLower()); break;
              case "Model": canAdd = data.Model.ToLower().Contains(query.ToLower()); break;
              case "Price": try { canAdd = !string.IsNullOrEmpty(query) && data.Price <= Convert.ToUInt32(query); } catch { canAdd = false; } break;
              case "Body Type": canAdd = Enum.GetName(typeof(Body), (Body)data.Body).ToLower().Contains(query.ToLower()); break;
              case "Fuel Type": canAdd = Enum.GetName(typeof(Fuel), (Fuel)data.Fuel).ToLower().Contains(query.ToLower()); break;
            }
          }
          catch
          {
            canAdd = false;
          }
          if (canAdd)
          {
            string car = Convert.ToString(data.Year) + " " + data.Make + " " + data.Model;
            ListingsDataGridView.Rows.Add(new object[] { Convert.ToString(data.Code), car, // Code column is hidden for data purposes
            Enum.GetName(typeof(Body), (Body)data.Body), Enum.GetName(typeof(Fuel), (Fuel)data.Fuel), Convert.ToString(data.Price),
            Convert.ToString(data.Year), Convert.ToString(data.Make), Convert.ToString(data.Model) }); // These columns are hidden
          }
        }
      }
      OrderDataGridViewBy("Model");
    }

    private void OrderDataGridViewBy(string column)
    {
      ListingsDataGridView.Sort(ListingsDataGridView.Columns[column], ListSortDirection.Descending);
      AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
      var values = ListingsDataGridView.Rows.Cast<DataGridViewRow>()
                           .Select(x => x.Cells[column].Value.ToString())
                           .Distinct()
                           .ToArray();
      autoComplete.CopyTo(values, 0);
      SearchTextBox.AutoCompleteCustomSource = autoComplete;
    }

    private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      string s = "Make";
      try
      {
        s = SearchByComboBox.SelectedItem.ToString();
        switch (s)
        {
          case "Year": SearchTextBox.PlaceholderText = "Year..."; break;
          case "Make": SearchTextBox.PlaceholderText = "Make..."; break;
          case "Model": SearchTextBox.PlaceholderText = "Model..."; break;
          case "Price": SearchTextBox.PlaceholderText = "Max Price..."; break;
          case "Body Type": SearchTextBox.PlaceholderText = "Body Type..."; break;
          case "Fuel Type": SearchTextBox.PlaceholderText = "Fuel Type..."; break;
        }
      }
      catch {
        SearchTextBox.PlaceholderText = "Make...";
      }
      if (string.IsNullOrEmpty(SearchTextBox.Text))
      {
        RefreshDataGridView();
      }
      else
      {
        RefreshDataGridViewBySearch(s);
      }
    }

    private void ListingsDataGridView_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
    {
      if (e.CellValue1 == e.CellValue2)
      {
        int order = -1;
        string altcol = "Make";
        if (e.Column.Name == "Make") altcol = "Model";
        if (e.Column.Name == "Model") altcol = "Year";
        if (e.Column.Name == "Year") altcol = "Body";
        if (e.Column.Name == "Body") altcol = "Fuel";
        if (e.Column.Name == "Fuel") altcol = "Price";

        string s1 = ListingsDataGridView[altcol, e.RowIndex1].Value.ToString();
        string s2 = ListingsDataGridView[altcol, e.RowIndex2].Value.ToString();
        e.SortResult = string.Compare(s1, s2) * order;
        e.Handled = true;
      }
    }

    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {

      if (string.IsNullOrEmpty(SearchTextBox.Text))
      {
        RefreshDataGridView();
      }
      else
      {
        RefreshDataGridViewBySearch(SearchTextBox.Text);
      }
    }

    private void ListingsDataGridView_SelectionChanged(object sender, EventArgs e)
    {
      if (ListingsDataGridView.SelectedRows.Count == 1)
      {
        DetailsButton.Visible = true;
      }
      else
      {
        DetailsButton.Visible = false;
      }
    }

    private void AllListingsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (Program.shouldExitOnClose)
      {
        Program.logInForm.Close();
      }
    }
  }
}
