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
  public partial class LogInForm : Form
  {
    public LogInForm()
    {
      InitializeComponent();
      Program.logInForm = this;
    }

    private void LogInButton_Click(object sender, EventArgs e)
    {
      if (Program.SessionId == null)
      {
        User user = new User();
        user.Name = UsernameTextBox.Text; user.Password = PasswordTextBox.Text;
        Session_Id tempid = Program.client.Login(user);
        UsernameTextBox.Clear(); PasswordTextBox.Clear();
        if (string.IsNullOrEmpty(tempid.Id))
        {
          MessageBox.Show("Wrong username/password");
        }
        else
        {
          Program.SessionId = tempid.Id;
          Program.Username = user.Name;
          MessageBox.Show("Successfully Logged In");
          AllListingsForm listingsForm = new AllListingsForm();
          listingsForm.Show();
          Hide();
        }
      }
      else
      {
        MessageBox.Show("You're already logged in...");
        AllListingsForm listingsForm = new AllListingsForm();
        listingsForm.Show();
        Hide();
      }
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
      if (Program.SessionId == null)
      {
        User user = new User();
        user.Name = UsernameTextBox.Text; user.Password = PasswordTextBox.Text;
        Session_Id tempid = Program.client.Register(user);
        UsernameTextBox.Clear(); PasswordTextBox.Clear();
        if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password))
        {
          MessageBox.Show("Username and Password cannot be empty!");
        }
        else if (string.IsNullOrEmpty(tempid.Id))
        {
          MessageBox.Show("Username already in use");
        }
        else
        {
          Program.SessionId = tempid.Id;
          Program.Username = user.Name;
          MessageBox.Show("Successfully Registered");
          AllListingsForm listingsForm = new AllListingsForm();
          listingsForm.Show();
          Hide();
        }
      }
      else
      {
        MessageBox.Show("You're already logged in...");
        AllListingsForm listingsForm = new AllListingsForm();
        listingsForm.Show();
        Hide();
      }
    }

    static readonly char[] validUsernameChars = new char[] { '.', '_', '-' };
    static readonly char[] validPasswordChars = new char[] { '.', '_', '-', '*', '+', '/', '?', '!', '~', '|', '<', '>', '$', '€', '=', '(', ')', '%', '[', ']', '{', '}' };

    private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      char key = e.KeyChar;
      if (!(char.IsLetterOrDigit(key) || char.IsControl(key) || validUsernameChars.Contains(key)))
      {
        e.Handled = true;
      }
    }

    private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {

      char key = e.KeyChar;
      if (!(char.IsLetterOrDigit(key) || char.IsControl(key) || validPasswordChars.Contains(key)))
      {
        e.Handled = true;
      }
    }
  }
}
