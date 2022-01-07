
namespace CarMarktClient.Controls
{
  partial class CommentControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.OwnerAndTimeLabel = new System.Windows.Forms.Label();
      this.MessageTextBox = new System.Windows.Forms.RichTextBox();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.SuspendLayout();
      // 
      // OwnerAndTimeLabel
      // 
      this.OwnerAndTimeLabel.AutoSize = true;
      this.OwnerAndTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.OwnerAndTimeLabel.Location = new System.Drawing.Point(0, 0);
      this.OwnerAndTimeLabel.Name = "OwnerAndTimeLabel";
      this.OwnerAndTimeLabel.Size = new System.Drawing.Size(95, 15);
      this.OwnerAndTimeLabel.TabIndex = 0;
      this.OwnerAndTimeLabel.Text = "{Owner} - {Time}";
      // 
      // MessageTextBox
      // 
      this.MessageTextBox.BackColor = System.Drawing.SystemColors.Control;
      this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.MessageTextBox.Location = new System.Drawing.Point(0, 16);
      this.MessageTextBox.MaxLength = 250;
      this.MessageTextBox.Name = "MessageTextBox";
      this.MessageTextBox.ReadOnly = true;
      this.MessageTextBox.Size = new System.Drawing.Size(350, 79);
      this.MessageTextBox.TabIndex = 2;
      this.MessageTextBox.Text = "";
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 95);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(350, 5);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      // 
      // CommentControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.MessageTextBox);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.OwnerAndTimeLabel);
      this.MaximumSize = new System.Drawing.Size(350, 100);
      this.MinimumSize = new System.Drawing.Size(350, 100);
      this.Name = "CommentControl";
      this.Size = new System.Drawing.Size(350, 100);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label OwnerAndTimeLabel;
    private System.Windows.Forms.RichTextBox MessageTextBox;
    private System.Windows.Forms.Splitter splitter1;
  }
}
