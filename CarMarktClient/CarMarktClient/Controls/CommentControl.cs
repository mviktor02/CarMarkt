using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarMarktClient.Controls
{
  public partial class CommentControl : UserControl
  {

    public CommentControl()
    {
      InitializeComponent();
    }

    public string OwnerAndTime
    {
      set
      {
        OwnerAndTimeLabel.Text = value;
      }
    }

    public string Message
    {
      set
      {
        MessageTextBox.Text = value;
      }
    }
  }
}
