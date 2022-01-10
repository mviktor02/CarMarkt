using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarMarktClient
{
  public partial class NewListingForm : Form
  {
    static readonly string[] bodyTypes = Enum.GetNames(typeof(Body));
    static readonly string[] fuelTypes = Enum.GetNames(typeof(Fuel));
    public NewListingForm()
    {
      InitializeComponent();
      BodyTypeComboBox.DataSource = bodyTypes;
      BodyTypeComboBox.SelectedItem = bodyTypes[0];
      FuelTypeComboBox.DataSource = fuelTypes;
      FuelTypeComboBox.SelectedItem = fuelTypes[0];
      YearUpDown.Maximum = DateTime.Now.Year;
      PriceUpDown.Maximum = uint.MaxValue;
      Program.shouldExitOnClose = true;
    }

    private void CreateListingButton_Click(object sender, EventArgs e)
    {
      bool canCreate;
      try
      {
        canCreate = !(string.IsNullOrWhiteSpace(MakeTextBox.Text) || string.IsNullOrWhiteSpace(ModelTextBox.Text)
        || string.IsNullOrWhiteSpace(BodyTypeComboBox.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(FuelTypeComboBox.SelectedItem.ToString())
        || string.IsNullOrEmpty(PhoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text));
      }
      catch
      {
        canCreate = false;
      }
      if (!canCreate)
      {
        MessageBox.Show("Please fill in all fields");
      }
      else
      {
        FullCarData data = new FullCarData();
        Session_Id session = new Session_Id(); session.Id = Program.SessionId;
        data.Session = session; 
        PartialCarData partialData = new PartialCarData();
        partialData.Year = (uint)YearUpDown.Value;
        partialData.Make = MakeTextBox.Text;
        partialData.Model = ModelTextBox.Text;
        partialData.Body = (uint)BodyTypeComboBox.SelectedIndex;
        partialData.Fuel = (uint)FuelTypeComboBox.SelectedIndex;
        partialData.Price = (uint)PriceUpDown.Value;
        data.PartialData = partialData;
        data.Description = DescriptionTextBox.Text;
        data.OwnerName = Program.Username;
        data.PhoneNumber = PhoneNumberTextBox.Text;
        Result result = Program.client.AddListing(data);
        MessageBox.Show(result.Message);
        if (result.Message == "Successfully added listing")
        {
          Program.shouldExitOnClose = false;
          Close();
        }
      }
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
      Program.shouldExitOnClose = false;
      Close();
    }

    private void NewListingForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (Program.shouldExitOnClose)
      {
        Program.logInForm.Close();
      }
      else
      {
        AllListingsForm listingsForm = new AllListingsForm();
        listingsForm.Show();
      }
    }
  }
}
