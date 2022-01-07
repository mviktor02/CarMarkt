
namespace CarMarktClient
{
  partial class LogInForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.LogInButton = new System.Windows.Forms.Button();
      this.RegisterButton = new System.Windows.Forms.Button();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.UsernameTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // LogInButton
      // 
      this.LogInButton.Location = new System.Drawing.Point(238, 230);
      this.LogInButton.Name = "LogInButton";
      this.LogInButton.Size = new System.Drawing.Size(75, 23);
      this.LogInButton.TabIndex = 2;
      this.LogInButton.Text = "Log In";
      this.LogInButton.UseVisualStyleBackColor = true;
      this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
      // 
      // RegisterButton
      // 
      this.RegisterButton.Location = new System.Drawing.Point(444, 230);
      this.RegisterButton.Name = "RegisterButton";
      this.RegisterButton.Size = new System.Drawing.Size(75, 23);
      this.RegisterButton.TabIndex = 3;
      this.RegisterButton.Text = "Register";
      this.RegisterButton.UseVisualStyleBackColor = true;
      this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(380, 186);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.PlaceholderText = "Password";
      this.PasswordTextBox.Size = new System.Drawing.Size(202, 23);
      this.PasswordTextBox.TabIndex = 1;
      this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.Location = new System.Drawing.Point(180, 186);
      this.UsernameTextBox.MaxLength = 20;
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.PlaceholderText = "Username";
      this.UsernameTextBox.Size = new System.Drawing.Size(194, 23);
      this.UsernameTextBox.TabIndex = 0;
      this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.UsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
      // 
      // LogInForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.UsernameTextBox);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.RegisterButton);
      this.Controls.Add(this.LogInButton);
      this.Name = "LogInForm";
      this.Text = "CarMarkt - Log In";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button LogInButton;
    private System.Windows.Forms.Button RegisterButton;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.TextBox UsernameTextBox;
  }
}

