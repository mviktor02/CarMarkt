using CarMarktClient.Controls;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMarktClient
{
  public partial class CurrentListingForm : Form
  {
    
    private FullCarData carData;

    public CurrentListingForm(FullCarData data)
    {
      InitializeComponent();
      carData = data;
      Program.shouldExitOnClose = true;
    }

    private void CurrentListingForm_Load(object sender, EventArgs e)
    {
      CarLabel.Text = Convert.ToString(carData.PartialData.Year) + " " + carData.PartialData.Make + " " + carData.PartialData.Model;
      CarLabel.Left = Width / 2 - CarLabel.Width / 2;
      Text = "CarMarkt - " + CarLabel.Text;
      var origRight = OwnerLabel.Right;
      OwnerLabel.Text = "Owner - " + carData.OwnerName;
      if (OwnerLabel.Right > origRight)
      {
        OwnerLabel.Left = OwnerLabel.Left - (OwnerLabel.Right - origRight);
      }
      origRight = PhoneNumberLabel.Right;
      PhoneNumberLabel.Text = "Phone Number - " + carData.PhoneNumber;
      if (PhoneNumberLabel.Right > origRight)
      {
        PhoneNumberLabel.Left = PhoneNumberLabel.Left - (PhoneNumberLabel.Right - origRight);
      }
      BodyLabel.Text = "Body Type - " + Enum.GetName(typeof(Body), carData.PartialData.Body);
      FuelLabel.Text = "Fuel Type - " + Enum.GetName(typeof(Fuel), carData.PartialData.Fuel);
      PriceLabel.Text = "Price - " + Convert.ToString(carData.PartialData.Price) + "€";
      DescriptionTextBox.Text = carData.Description;
      if (carData.OwnerName == Program.Username)
      {
        RemoveButton.Visible = true;
      }
      RefreshComments();
    }

    private async void RefreshComments()
    {
      CommentLayout.Controls.Clear();
      List<CommentMessage> comments = new List<CommentMessage>();
      using (var call = Program.client.ViewComments(new CarCode { Code = carData.PartialData.Code }))
      {
        while (await call.ResponseStream.MoveNext())
        {
          CommentMessage comment = call.ResponseStream.Current;
          comments.Add(comment);
        }
      }

      comments = comments.OrderBy(comment => comment.Time).ToList();

      foreach (CommentMessage comment in comments)
      {
        CommentControl commentControl = new CommentControl();
        commentControl.OwnerAndTime = comment.Owner + " - " + getRelativeDateTime(comment.Time);
        commentControl.Message = comment.Message;
        CommentLayout.Controls.Add(commentControl);
      }
    }

    public string getRelativeDateTime(string date)
    {
      DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd HH:mm:ss", null);
      TimeSpan ts = DateTime.Now - dateTime;
      if (ts.TotalMinutes < 1)//seconds ago
        return (int)ts.TotalSeconds == 1 ? "just now" : (int)ts.TotalSeconds + " seconds ago";
      if (ts.TotalHours < 1)//min ago
        return (int)ts.TotalMinutes == 1 ? "a minute ago" : (int)ts.TotalMinutes + " minutes ago";
      if (ts.TotalDays < 1)//hours ago
        return (int)ts.TotalHours == 1 ? "an hour ago" : (int)ts.TotalHours + " hours ago";
      if (ts.TotalDays < 7)//days ago
        return (int)ts.TotalDays == 1 ? "yesterday" : (int)ts.TotalDays + " days ago";
      if (ts.TotalDays < 30.4368)//weeks ago
        return (int)(ts.TotalDays / 7) == 1 ? "a week ago" : (int)(ts.TotalDays / 7) + " weeks ago";
      if (ts.TotalDays < 365.242)//months ago
        return (int)(ts.TotalDays / 30.4368) == 1 ? "one month ago" : (int)(ts.TotalDays / 30.4368) + " months ago";
      //years ago
      return (int)(ts.TotalDays / 365.242) == 1 ? "one year ago" : (int)(ts.TotalDays / 365.242) + " years ago";
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
      Program.shouldExitOnClose = false;
      Close();
    }

    private void CommentButton_Click(object sender, EventArgs e)
    {
      CommentMessage comment = new CommentMessage();
      comment.Code = carData.PartialData.Code;
      comment.OwnerId = Program.SessionId;
      comment.Owner = Program.Username;
      comment.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
      comment.Message = CommentTextBox.Text;
      Result result = Program.client.Comment(comment);
      MessageBox.Show(result.Message);
      RefreshComments();
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
      RemovalData removalData = new RemovalData();
      removalData.Code = carData.PartialData.Code;
      removalData.OwnerId = Program.SessionId;
      removalData.OwnerName = Program.Username;
      Result result = Program.client.RemoveListing(removalData);
      MessageBox.Show(result.Message);
      if (result.Message == "Successfully removed listing")
      {
        Program.shouldExitOnClose = false;
        Close();
      }
    }

    private void CurrentListingForm_FormClosed(object sender, FormClosedEventArgs e)
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
