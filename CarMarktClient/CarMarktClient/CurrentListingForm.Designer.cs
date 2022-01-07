
namespace CarMarktClient
{
  partial class CurrentListingForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.CarLabel = new System.Windows.Forms.Label();
      this.BodyLabel = new System.Windows.Forms.Label();
      this.FuelLabel = new System.Windows.Forms.Label();
      this.OwnerLabel = new System.Windows.Forms.Label();
      this.PriceLabel = new System.Windows.Forms.Label();
      this.PhoneNumberLabel = new System.Windows.Forms.Label();
      this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
      this.CommentLayout = new System.Windows.Forms.FlowLayoutPanel();
      this.BackButton = new System.Windows.Forms.Button();
      this.CommentTextBox = new System.Windows.Forms.RichTextBox();
      this.CommentButton = new System.Windows.Forms.Button();
      this.RemoveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CarLabel
      // 
      this.CarLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.CarLabel.AutoSize = true;
      this.CarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.CarLabel.Location = new System.Drawing.Point(372, 9);
      this.CarLabel.Name = "CarLabel";
      this.CarLabel.Size = new System.Drawing.Size(53, 25);
      this.CarLabel.TabIndex = 0;
      this.CarLabel.Text = "{Car}";
      this.CarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // BodyLabel
      // 
      this.BodyLabel.AutoSize = true;
      this.BodyLabel.Location = new System.Drawing.Point(12, 47);
      this.BodyLabel.Name = "BodyLabel";
      this.BodyLabel.Size = new System.Drawing.Size(107, 15);
      this.BodyLabel.TabIndex = 1;
      this.BodyLabel.Text = "Body Type - {Body}";
      // 
      // FuelLabel
      // 
      this.FuelLabel.AutoSize = true;
      this.FuelLabel.Location = new System.Drawing.Point(12, 62);
      this.FuelLabel.Name = "FuelLabel";
      this.FuelLabel.Size = new System.Drawing.Size(97, 15);
      this.FuelLabel.TabIndex = 2;
      this.FuelLabel.Text = "Fuel Type - {Fuel}";
      // 
      // OwnerLabel
      // 
      this.OwnerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.OwnerLabel.AutoSize = true;
      this.OwnerLabel.Location = new System.Drawing.Point(692, 47);
      this.OwnerLabel.Name = "OwnerLabel";
      this.OwnerLabel.Size = new System.Drawing.Size(96, 15);
      this.OwnerLabel.TabIndex = 3;
      this.OwnerLabel.Text = "Owner - {Owner}";
      this.OwnerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // PriceLabel
      // 
      this.PriceLabel.AutoSize = true;
      this.PriceLabel.Location = new System.Drawing.Point(12, 77);
      this.PriceLabel.Name = "PriceLabel";
      this.PriceLabel.Size = new System.Drawing.Size(78, 15);
      this.PriceLabel.TabIndex = 4;
      this.PriceLabel.Text = "Price - {Price}";
      // 
      // PhoneNumberLabel
      // 
      this.PhoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.PhoneNumberLabel.AutoSize = true;
      this.PhoneNumberLabel.Location = new System.Drawing.Point(650, 62);
      this.PhoneNumberLabel.Name = "PhoneNumberLabel";
      this.PhoneNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.PhoneNumberLabel.Size = new System.Drawing.Size(138, 15);
      this.PhoneNumberLabel.TabIndex = 5;
      this.PhoneNumberLabel.Text = "Phone - {PhoneNumber}";
      this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DescriptionTextBox.Enabled = false;
      this.DescriptionTextBox.Location = new System.Drawing.Point(44, 105);
      this.DescriptionTextBox.MaxLength = 500;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.ReadOnly = true;
      this.DescriptionTextBox.Size = new System.Drawing.Size(710, 157);
      this.DescriptionTextBox.TabIndex = 6;
      this.DescriptionTextBox.Text = "{Description}";
      // 
      // CommentLayout
      // 
      this.CommentLayout.AutoScroll = true;
      this.CommentLayout.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
      this.CommentLayout.Location = new System.Drawing.Point(12, 276);
      this.CommentLayout.Name = "CommentLayout";
      this.CommentLayout.Size = new System.Drawing.Size(381, 131);
      this.CommentLayout.TabIndex = 7;
      this.CommentLayout.WrapContents = false;
      // 
      // BackButton
      // 
      this.BackButton.Location = new System.Drawing.Point(12, 415);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(75, 23);
      this.BackButton.TabIndex = 8;
      this.BackButton.Text = "Back";
      this.BackButton.UseVisualStyleBackColor = true;
      this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
      // 
      // CommentTextBox
      // 
      this.CommentTextBox.BackColor = System.Drawing.SystemColors.Control;
      this.CommentTextBox.Location = new System.Drawing.Point(408, 276);
      this.CommentTextBox.Name = "CommentTextBox";
      this.CommentTextBox.Size = new System.Drawing.Size(380, 102);
      this.CommentTextBox.TabIndex = 9;
      this.CommentTextBox.Text = "";
      // 
      // CommentButton
      // 
      this.CommentButton.Location = new System.Drawing.Point(408, 384);
      this.CommentButton.Name = "CommentButton";
      this.CommentButton.Size = new System.Drawing.Size(380, 23);
      this.CommentButton.TabIndex = 11;
      this.CommentButton.Text = "Comment";
      this.CommentButton.UseVisualStyleBackColor = true;
      this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
      // 
      // RemoveButton
      // 
      this.RemoveButton.Location = new System.Drawing.Point(346, 47);
      this.RemoveButton.Name = "RemoveButton";
      this.RemoveButton.Size = new System.Drawing.Size(107, 23);
      this.RemoveButton.TabIndex = 12;
      this.RemoveButton.Text = "Remove Listing";
      this.RemoveButton.UseVisualStyleBackColor = true;
      this.RemoveButton.Visible = false;
      this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
      // 
      // CurrentListingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.RemoveButton);
      this.Controls.Add(this.CommentButton);
      this.Controls.Add(this.CommentTextBox);
      this.Controls.Add(this.BackButton);
      this.Controls.Add(this.CommentLayout);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.PhoneNumberLabel);
      this.Controls.Add(this.PriceLabel);
      this.Controls.Add(this.OwnerLabel);
      this.Controls.Add(this.FuelLabel);
      this.Controls.Add(this.BodyLabel);
      this.Controls.Add(this.CarLabel);
      this.Name = "CurrentListingForm";
      this.Text = "CarMarkt - {Listing}";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentListingForm_FormClosed);
      this.Load += new System.EventHandler(this.CurrentListingForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label CarLabel;
    private System.Windows.Forms.Label BodyLabel;
    private System.Windows.Forms.Label FuelLabel;
    private System.Windows.Forms.Label OwnerLabel;
    private System.Windows.Forms.Label PriceLabel;
    private System.Windows.Forms.Label PhoneNumberLabel;
    private System.Windows.Forms.RichTextBox DescriptionTextBox;
    private System.Windows.Forms.FlowLayoutPanel CommentLayout;
    private System.Windows.Forms.Button BackButton;
    private System.Windows.Forms.RichTextBox CommentTextBox;
    private System.Windows.Forms.Button CommentButton;
    private System.Windows.Forms.Button RemoveButton;
  }
}