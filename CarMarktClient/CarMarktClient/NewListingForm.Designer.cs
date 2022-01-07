
namespace CarMarktClient
{
  partial class NewListingForm
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
      this.ModelTextBox = new System.Windows.Forms.TextBox();
      this.MakeTextBox = new System.Windows.Forms.TextBox();
      this.FuelTypeComboBox = new System.Windows.Forms.ComboBox();
      this.BodyTypeComboBox = new System.Windows.Forms.ComboBox();
      this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
      this.BodyTypeLabel = new System.Windows.Forms.Label();
      this.FuelTypeLabel = new System.Windows.Forms.Label();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.CreateListingButton = new System.Windows.Forms.Button();
      this.BackButton = new System.Windows.Forms.Button();
      this.YearUpDown = new System.Windows.Forms.NumericUpDown();
      this.YearLabel = new System.Windows.Forms.Label();
      this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
      this.PriceLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // ModelTextBox
      // 
      this.ModelTextBox.Location = new System.Drawing.Point(527, 12);
      this.ModelTextBox.MaxLength = 200;
      this.ModelTextBox.Name = "ModelTextBox";
      this.ModelTextBox.PlaceholderText = "Model...";
      this.ModelTextBox.Size = new System.Drawing.Size(261, 23);
      this.ModelTextBox.TabIndex = 0;
      // 
      // MakeTextBox
      // 
      this.MakeTextBox.Location = new System.Drawing.Point(260, 12);
      this.MakeTextBox.MaxLength = 100;
      this.MakeTextBox.Name = "MakeTextBox";
      this.MakeTextBox.PlaceholderText = "Make...";
      this.MakeTextBox.Size = new System.Drawing.Size(261, 23);
      this.MakeTextBox.TabIndex = 1;
      // 
      // FuelTypeComboBox
      // 
      this.FuelTypeComboBox.FormattingEnabled = true;
      this.FuelTypeComboBox.Location = new System.Drawing.Point(87, 70);
      this.FuelTypeComboBox.Name = "FuelTypeComboBox";
      this.FuelTypeComboBox.Size = new System.Drawing.Size(167, 23);
      this.FuelTypeComboBox.TabIndex = 3;
      // 
      // BodyTypeComboBox
      // 
      this.BodyTypeComboBox.FormattingEnabled = true;
      this.BodyTypeComboBox.Location = new System.Drawing.Point(87, 41);
      this.BodyTypeComboBox.Name = "BodyTypeComboBox";
      this.BodyTypeComboBox.Size = new System.Drawing.Size(167, 23);
      this.BodyTypeComboBox.TabIndex = 4;
      // 
      // PhoneNumberTextBox
      // 
      this.PhoneNumberTextBox.Location = new System.Drawing.Point(260, 70);
      this.PhoneNumberTextBox.MaxLength = 50;
      this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
      this.PhoneNumberTextBox.PlaceholderText = "Phone Number...";
      this.PhoneNumberTextBox.Size = new System.Drawing.Size(261, 23);
      this.PhoneNumberTextBox.TabIndex = 6;
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Location = new System.Drawing.Point(12, 114);
      this.DescriptionTextBox.MaxLength = 500;
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(776, 295);
      this.DescriptionTextBox.TabIndex = 7;
      this.DescriptionTextBox.Text = "";
      // 
      // BodyTypeLabel
      // 
      this.BodyTypeLabel.AutoSize = true;
      this.BodyTypeLabel.Location = new System.Drawing.Point(12, 44);
      this.BodyTypeLabel.Name = "BodyTypeLabel";
      this.BodyTypeLabel.Size = new System.Drawing.Size(69, 15);
      this.BodyTypeLabel.TabIndex = 8;
      this.BodyTypeLabel.Text = "Body Type -";
      // 
      // FuelTypeLabel
      // 
      this.FuelTypeLabel.AutoSize = true;
      this.FuelTypeLabel.Location = new System.Drawing.Point(12, 73);
      this.FuelTypeLabel.Name = "FuelTypeLabel";
      this.FuelTypeLabel.Size = new System.Drawing.Size(64, 15);
      this.FuelTypeLabel.TabIndex = 9;
      this.FuelTypeLabel.Text = "Fuel Type -";
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(353, 96);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
      this.DescriptionLabel.TabIndex = 10;
      this.DescriptionLabel.Text = "Description";
      // 
      // CreateListingButton
      // 
      this.CreateListingButton.Location = new System.Drawing.Point(403, 415);
      this.CreateListingButton.Name = "CreateListingButton";
      this.CreateListingButton.Size = new System.Drawing.Size(385, 23);
      this.CreateListingButton.TabIndex = 11;
      this.CreateListingButton.Text = "Create Listing";
      this.CreateListingButton.UseVisualStyleBackColor = true;
      this.CreateListingButton.Click += new System.EventHandler(this.CreateListingButton_Click);
      // 
      // BackButton
      // 
      this.BackButton.Location = new System.Drawing.Point(16, 415);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(381, 23);
      this.BackButton.TabIndex = 12;
      this.BackButton.Text = "Cancel";
      this.BackButton.UseVisualStyleBackColor = true;
      this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
      // 
      // YearUpDown
      // 
      this.YearUpDown.Location = new System.Drawing.Point(87, 12);
      this.YearUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
      this.YearUpDown.Minimum = new decimal(new int[] {
            1885,
            0,
            0,
            0});
      this.YearUpDown.Name = "YearUpDown";
      this.YearUpDown.Size = new System.Drawing.Size(167, 23);
      this.YearUpDown.TabIndex = 13;
      this.YearUpDown.Value = new decimal(new int[] {
            1885,
            0,
            0,
            0});
      // 
      // YearLabel
      // 
      this.YearLabel.AutoSize = true;
      this.YearLabel.Location = new System.Drawing.Point(12, 14);
      this.YearLabel.Name = "YearLabel";
      this.YearLabel.Size = new System.Drawing.Size(37, 15);
      this.YearLabel.TabIndex = 14;
      this.YearLabel.Text = "Year -";
      // 
      // PriceUpDown
      // 
      this.PriceUpDown.Location = new System.Drawing.Point(261, 42);
      this.PriceUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.PriceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.PriceUpDown.Name = "PriceUpDown";
      this.PriceUpDown.Size = new System.Drawing.Size(260, 23);
      this.PriceUpDown.TabIndex = 15;
      this.PriceUpDown.ThousandsSeparator = true;
      this.PriceUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // PriceLabel
      // 
      this.PriceLabel.AutoSize = true;
      this.PriceLabel.Location = new System.Drawing.Point(527, 44);
      this.PriceLabel.Name = "PriceLabel";
      this.PriceLabel.Size = new System.Drawing.Size(58, 15);
      this.PriceLabel.TabIndex = 16;
      this.PriceLabel.Text = "- Price (€)";
      // 
      // NewListingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.PriceLabel);
      this.Controls.Add(this.PriceUpDown);
      this.Controls.Add(this.YearLabel);
      this.Controls.Add(this.YearUpDown);
      this.Controls.Add(this.BackButton);
      this.Controls.Add(this.CreateListingButton);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.FuelTypeLabel);
      this.Controls.Add(this.BodyTypeLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.PhoneNumberTextBox);
      this.Controls.Add(this.BodyTypeComboBox);
      this.Controls.Add(this.FuelTypeComboBox);
      this.Controls.Add(this.MakeTextBox);
      this.Controls.Add(this.ModelTextBox);
      this.Name = "NewListingForm";
      this.Text = "CarMarkt - New Listing";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewListingForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ModelTextBox;
    private System.Windows.Forms.TextBox MakeTextBox;
    private System.Windows.Forms.ComboBox FuelTypeComboBox;
    private System.Windows.Forms.ComboBox BodyTypeComboBox;
    private System.Windows.Forms.TextBox PhoneNumberTextBox;
    private System.Windows.Forms.RichTextBox DescriptionTextBox;
    private System.Windows.Forms.Label BodyTypeLabel;
    private System.Windows.Forms.Label FuelTypeLabel;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.Button CreateListingButton;
    private System.Windows.Forms.Button BackButton;
    private System.Windows.Forms.NumericUpDown YearUpDown;
    private System.Windows.Forms.Label YearLabel;
    private System.Windows.Forms.NumericUpDown PriceUpDown;
    private System.Windows.Forms.Label PriceLabel;
  }
}