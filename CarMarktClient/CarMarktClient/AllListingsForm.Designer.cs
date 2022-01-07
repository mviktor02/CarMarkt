
namespace CarMarktClient
{
  partial class AllListingsForm
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
      this.ListingsDataGridView = new System.Windows.Forms.DataGridView();
      this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.DetailsButton = new System.Windows.Forms.Button();
      this.AddListingButton = new System.Windows.Forms.Button();
      this.LogOutButton = new System.Windows.Forms.Button();
      this.SearchByComboBox = new System.Windows.Forms.ComboBox();
      this.OrderByLabel = new System.Windows.Forms.Label();
      this.SearchTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.ListingsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ListingsDataGridView
      // 
      this.ListingsDataGridView.AllowUserToAddRows = false;
      this.ListingsDataGridView.AllowUserToDeleteRows = false;
      this.ListingsDataGridView.AllowUserToResizeRows = false;
      this.ListingsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.ListingsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
      this.ListingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ListingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Car,
            this.Body,
            this.Fuel,
            this.Price,
            this.Year,
            this.Make,
            this.Model});
      this.ListingsDataGridView.Location = new System.Drawing.Point(12, 12);
      this.ListingsDataGridView.MultiSelect = false;
      this.ListingsDataGridView.Name = "ListingsDataGridView";
      this.ListingsDataGridView.ReadOnly = true;
      this.ListingsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      this.ListingsDataGridView.RowTemplate.Height = 25;
      this.ListingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ListingsDataGridView.Size = new System.Drawing.Size(776, 397);
      this.ListingsDataGridView.TabIndex = 0;
      this.ListingsDataGridView.SelectionChanged += new System.EventHandler(this.ListingsDataGridView_SelectionChanged);
      this.ListingsDataGridView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.ListingsDataGridView_SortCompare);
      // 
      // Code
      // 
      this.Code.HeaderText = "Code";
      this.Code.Name = "Code";
      this.Code.ReadOnly = true;
      this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Code.Visible = false;
      // 
      // Car
      // 
      this.Car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Car.HeaderText = "Car";
      this.Car.Name = "Car";
      this.Car.ReadOnly = true;
      this.Car.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // Body
      // 
      this.Body.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Body.HeaderText = "Body Type";
      this.Body.Name = "Body";
      this.Body.ReadOnly = true;
      // 
      // Fuel
      // 
      this.Fuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Fuel.HeaderText = "Fuel Type";
      this.Fuel.Name = "Fuel";
      this.Fuel.ReadOnly = true;
      // 
      // Price
      // 
      this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Price.HeaderText = "Price (€)";
      this.Price.Name = "Price";
      this.Price.ReadOnly = true;
      // 
      // Year
      // 
      this.Year.HeaderText = "Year";
      this.Year.Name = "Year";
      this.Year.ReadOnly = true;
      this.Year.Visible = false;
      // 
      // Make
      // 
      this.Make.HeaderText = "Make";
      this.Make.Name = "Make";
      this.Make.ReadOnly = true;
      this.Make.Visible = false;
      // 
      // Model
      // 
      this.Model.HeaderText = "Model";
      this.Model.Name = "Model";
      this.Model.ReadOnly = true;
      this.Model.Visible = false;
      // 
      // RefreshButton
      // 
      this.RefreshButton.Location = new System.Drawing.Point(713, 415);
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(75, 23);
      this.RefreshButton.TabIndex = 1;
      this.RefreshButton.Text = "Refresh";
      this.RefreshButton.UseVisualStyleBackColor = true;
      this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
      // 
      // DetailsButton
      // 
      this.DetailsButton.Location = new System.Drawing.Point(632, 415);
      this.DetailsButton.Name = "DetailsButton";
      this.DetailsButton.Size = new System.Drawing.Size(75, 23);
      this.DetailsButton.TabIndex = 2;
      this.DetailsButton.Text = "Details";
      this.DetailsButton.UseVisualStyleBackColor = true;
      this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
      // 
      // AddListingButton
      // 
      this.AddListingButton.Location = new System.Drawing.Point(551, 415);
      this.AddListingButton.Name = "AddListingButton";
      this.AddListingButton.Size = new System.Drawing.Size(75, 23);
      this.AddListingButton.TabIndex = 3;
      this.AddListingButton.Text = "New";
      this.AddListingButton.UseVisualStyleBackColor = true;
      this.AddListingButton.Click += new System.EventHandler(this.AddListingButton_Click);
      // 
      // LogOutButton
      // 
      this.LogOutButton.Location = new System.Drawing.Point(12, 415);
      this.LogOutButton.Name = "LogOutButton";
      this.LogOutButton.Size = new System.Drawing.Size(75, 23);
      this.LogOutButton.TabIndex = 4;
      this.LogOutButton.Text = "Log Out";
      this.LogOutButton.UseVisualStyleBackColor = true;
      this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
      // 
      // SearchByComboBox
      // 
      this.SearchByComboBox.FormattingEnabled = true;
      this.SearchByComboBox.Location = new System.Drawing.Point(155, 416);
      this.SearchByComboBox.Name = "SearchByComboBox";
      this.SearchByComboBox.Size = new System.Drawing.Size(111, 23);
      this.SearchByComboBox.TabIndex = 5;
      this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
      // 
      // OrderByLabel
      // 
      this.OrderByLabel.AutoSize = true;
      this.OrderByLabel.Location = new System.Drawing.Point(93, 419);
      this.OrderByLabel.Name = "OrderByLabel";
      this.OrderByLabel.Size = new System.Drawing.Size(61, 15);
      this.OrderByLabel.TabIndex = 6;
      this.OrderByLabel.Text = "Search By:";
      this.OrderByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // SearchTextBox
      // 
      this.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.SearchTextBox.Location = new System.Drawing.Point(272, 416);
      this.SearchTextBox.Name = "SearchTextBox";
      this.SearchTextBox.PlaceholderText = "Search...";
      this.SearchTextBox.Size = new System.Drawing.Size(273, 23);
      this.SearchTextBox.TabIndex = 8;
      this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
      // 
      // AllListingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.SearchTextBox);
      this.Controls.Add(this.OrderByLabel);
      this.Controls.Add(this.SearchByComboBox);
      this.Controls.Add(this.LogOutButton);
      this.Controls.Add(this.AddListingButton);
      this.Controls.Add(this.DetailsButton);
      this.Controls.Add(this.RefreshButton);
      this.Controls.Add(this.ListingsDataGridView);
      this.Name = "AllListingsForm";
      this.Text = "CarMarkt - Listings";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllListingsForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.ListingsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView ListingsDataGridView;
    private System.Windows.Forms.Button RefreshButton;
    private System.Windows.Forms.Button DetailsButton;
    private System.Windows.Forms.Button AddListingButton;
    private System.Windows.Forms.Button LogOutButton;
    private System.Windows.Forms.ComboBox SearchByComboBox;
    private System.Windows.Forms.Label OrderByLabel;
    private System.Windows.Forms.TextBox SearchTextBox;
    private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    private System.Windows.Forms.DataGridViewTextBoxColumn Car;
    private System.Windows.Forms.DataGridViewTextBoxColumn Body;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fuel;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    private System.Windows.Forms.DataGridViewTextBoxColumn Make;
    private System.Windows.Forms.DataGridViewTextBoxColumn Model;
  }
}