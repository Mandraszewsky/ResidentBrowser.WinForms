namespace ResidentBrowser.WinForms.Forms.ResidentForms;

partial class ResidentForm
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
        residentsDataGridView = new DataGridView();
        addResidentButton = new Button();
        removeResidentButton = new Button();
        residentSearchNameTextBox = new TextBox();
        residentSearchNameLabel = new Label();
        residentSearchPESELLabel = new Label();
        residentSearchPESELTextBox = new TextBox();
        residentSearchProvinceLabel = new Label();
        residentSearchProvinceTextBox = new TextBox();
        residentResetFiltersButton = new Button();
        residentProfessionComboBox = new ComboBox();
        residentProfessionLabel = new Label();
        residentSkinColorLabel = new Label();
        residentSkinColorComboBox = new ComboBox();
        residentSearchToDateTimePicker = new DateTimePicker();
        residentSearchToLabel = new Label();
        residentSearchFromLabel = new Label();
        residentSearchFromDateTimePicker = new DateTimePicker();
        applayDateFilterButton = new Button();
        ((System.ComponentModel.ISupportInitialize)residentsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // residentsDataGridView
        // 
        residentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        residentsDataGridView.Location = new Point(21, 129);
        residentsDataGridView.Name = "residentsDataGridView";
        residentsDataGridView.Size = new Size(663, 320);
        residentsDataGridView.TabIndex = 0;
        // 
        // addResidentButton
        // 
        addResidentButton.Location = new Point(153, 470);
        addResidentButton.Name = "addResidentButton";
        addResidentButton.Size = new Size(160, 50);
        addResidentButton.TabIndex = 1;
        addResidentButton.Text = "Add resident";
        addResidentButton.UseVisualStyleBackColor = true;
        addResidentButton.Click += addResidentButton_Click;
        // 
        // removeResidentButton
        // 
        removeResidentButton.Location = new Point(360, 470);
        removeResidentButton.Name = "removeResidentButton";
        removeResidentButton.Size = new Size(160, 50);
        removeResidentButton.TabIndex = 2;
        removeResidentButton.Text = "Remove resident";
        removeResidentButton.UseVisualStyleBackColor = true;
        removeResidentButton.Click += removeResidentButton_Click;
        // 
        // residentSearchNameTextBox
        // 
        residentSearchNameTextBox.Location = new Point(21, 39);
        residentSearchNameTextBox.Name = "residentSearchNameTextBox";
        residentSearchNameTextBox.Size = new Size(190, 23);
        residentSearchNameTextBox.TabIndex = 3;
        residentSearchNameTextBox.TextChanged += residentTextBoxFilter_TextChanged;
        // 
        // residentSearchNameLabel
        // 
        residentSearchNameLabel.AutoSize = true;
        residentSearchNameLabel.Location = new Point(21, 21);
        residentSearchNameLabel.Name = "residentSearchNameLabel";
        residentSearchNameLabel.Size = new Size(97, 15);
        residentSearchNameLabel.TabIndex = 4;
        residentSearchNameLabel.Text = "Search by name :";
        // 
        // residentSearchPESELLabel
        // 
        residentSearchPESELLabel.AutoSize = true;
        residentSearchPESELLabel.Location = new Point(264, 21);
        residentSearchPESELLabel.Name = "residentSearchPESELLabel";
        residentSearchPESELLabel.Size = new Size(98, 15);
        residentSearchPESELLabel.TabIndex = 6;
        residentSearchPESELLabel.Text = "Search by PESEL :";
        // 
        // residentSearchPESELTextBox
        // 
        residentSearchPESELTextBox.Location = new Point(264, 39);
        residentSearchPESELTextBox.Name = "residentSearchPESELTextBox";
        residentSearchPESELTextBox.Size = new Size(190, 23);
        residentSearchPESELTextBox.TabIndex = 5;
        residentSearchPESELTextBox.TextChanged += residentTextBoxFilter_TextChanged;
        // 
        // residentSearchProvinceLabel
        // 
        residentSearchProvinceLabel.AutoSize = true;
        residentSearchProvinceLabel.Location = new Point(494, 21);
        residentSearchProvinceLabel.Name = "residentSearchProvinceLabel";
        residentSearchProvinceLabel.Size = new Size(113, 15);
        residentSearchProvinceLabel.TabIndex = 8;
        residentSearchProvinceLabel.Text = "Search by province :";
        // 
        // residentSearchProvinceTextBox
        // 
        residentSearchProvinceTextBox.Location = new Point(494, 39);
        residentSearchProvinceTextBox.Name = "residentSearchProvinceTextBox";
        residentSearchProvinceTextBox.Size = new Size(190, 23);
        residentSearchProvinceTextBox.TabIndex = 7;
        residentSearchProvinceTextBox.TextChanged += residentTextBoxFilter_TextChanged;
        // 
        // residentResetFiltersButton
        // 
        residentResetFiltersButton.Location = new Point(565, 85);
        residentResetFiltersButton.Name = "residentResetFiltersButton";
        residentResetFiltersButton.Size = new Size(119, 29);
        residentResetFiltersButton.TabIndex = 9;
        residentResetFiltersButton.Text = "Reset filters";
        residentResetFiltersButton.UseVisualStyleBackColor = true;
        residentResetFiltersButton.Click += residentResetFiltersButton_Click;
        // 
        // residentProfessionComboBox
        // 
        residentProfessionComboBox.FormattingEnabled = true;
        residentProfessionComboBox.Location = new Point(727, 186);
        residentProfessionComboBox.Name = "residentProfessionComboBox";
        residentProfessionComboBox.Size = new Size(147, 23);
        residentProfessionComboBox.TabIndex = 10;
        residentProfessionComboBox.SelectedIndexChanged += residentComboBoxFilter_SelectedIndexChanged;
        // 
        // residentProfessionLabel
        // 
        residentProfessionLabel.AutoSize = true;
        residentProfessionLabel.Location = new Point(727, 168);
        residentProfessionLabel.Name = "residentProfessionLabel";
        residentProfessionLabel.Size = new Size(68, 15);
        residentProfessionLabel.TabIndex = 11;
        residentProfessionLabel.Text = "Profession :";
        // 
        // residentSkinColorLabel
        // 
        residentSkinColorLabel.AutoSize = true;
        residentSkinColorLabel.Location = new Point(727, 235);
        residentSkinColorLabel.Name = "residentSkinColorLabel";
        residentSkinColorLabel.Size = new Size(65, 15);
        residentSkinColorLabel.TabIndex = 13;
        residentSkinColorLabel.Text = "Skin color :";
        // 
        // residentSkinColorComboBox
        // 
        residentSkinColorComboBox.FormattingEnabled = true;
        residentSkinColorComboBox.Location = new Point(727, 253);
        residentSkinColorComboBox.Name = "residentSkinColorComboBox";
        residentSkinColorComboBox.Size = new Size(147, 23);
        residentSkinColorComboBox.TabIndex = 12;
        residentSkinColorComboBox.SelectedIndexChanged += residentComboBoxFilter_SelectedIndexChanged;
        // 
        // residentSearchToDateTimePicker
        // 
        residentSearchToDateTimePicker.Format = DateTimePickerFormat.Short;
        residentSearchToDateTimePicker.Location = new Point(273, 91);
        residentSearchToDateTimePicker.Name = "residentSearchToDateTimePicker";
        residentSearchToDateTimePicker.Size = new Size(100, 23);
        residentSearchToDateTimePicker.TabIndex = 14;
        // 
        // residentSearchToLabel
        // 
        residentSearchToLabel.AutoSize = true;
        residentSearchToLabel.Location = new Point(273, 73);
        residentSearchToLabel.Name = "residentSearchToLabel";
        residentSearchToLabel.Size = new Size(51, 15);
        residentSearchToLabel.TabIndex = 15;
        residentSearchToLabel.Text = "Date to :";
        // 
        // residentSearchFromLabel
        // 
        residentSearchFromLabel.AutoSize = true;
        residentSearchFromLabel.Location = new Point(157, 73);
        residentSearchFromLabel.Name = "residentSearchFromLabel";
        residentSearchFromLabel.Size = new Size(66, 15);
        residentSearchFromLabel.TabIndex = 17;
        residentSearchFromLabel.Text = "Date from :";
        // 
        // residentSearchFromDateTimePicker
        // 
        residentSearchFromDateTimePicker.Format = DateTimePickerFormat.Short;
        residentSearchFromDateTimePicker.Location = new Point(157, 91);
        residentSearchFromDateTimePicker.Name = "residentSearchFromDateTimePicker";
        residentSearchFromDateTimePicker.Size = new Size(100, 23);
        residentSearchFromDateTimePicker.TabIndex = 16;
        // 
        // applayDateFilterButton
        // 
        applayDateFilterButton.Location = new Point(401, 85);
        applayDateFilterButton.Name = "applayDateFilterButton";
        applayDateFilterButton.Size = new Size(119, 29);
        applayDateFilterButton.TabIndex = 18;
        applayDateFilterButton.Text = "Applay date";
        applayDateFilterButton.UseVisualStyleBackColor = true;
        applayDateFilterButton.Click += applayDateFilterButton_Click;
        // 
        // ResidentForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 561);
        Controls.Add(applayDateFilterButton);
        Controls.Add(residentSearchFromLabel);
        Controls.Add(residentSearchFromDateTimePicker);
        Controls.Add(residentSearchToLabel);
        Controls.Add(residentSearchToDateTimePicker);
        Controls.Add(residentSkinColorLabel);
        Controls.Add(residentSkinColorComboBox);
        Controls.Add(residentProfessionLabel);
        Controls.Add(residentProfessionComboBox);
        Controls.Add(residentResetFiltersButton);
        Controls.Add(residentSearchProvinceLabel);
        Controls.Add(residentSearchProvinceTextBox);
        Controls.Add(residentSearchPESELLabel);
        Controls.Add(residentSearchPESELTextBox);
        Controls.Add(residentSearchNameLabel);
        Controls.Add(residentSearchNameTextBox);
        Controls.Add(removeResidentButton);
        Controls.Add(addResidentButton);
        Controls.Add(residentsDataGridView);
        Name = "ResidentForm";
        Text = "ResidentForm";
        Activated += ResidentForm_Activated;
        ((System.ComponentModel.ISupportInitialize)residentsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView residentsDataGridView;
    private Button addResidentButton;
    private Button removeResidentButton;
    private TextBox residentSearchNameTextBox;
    private Label residentSearchNameLabel;
    private Label residentSearchPESELLabel;
    private TextBox residentSearchPESELTextBox;
    private Label residentSearchProvinceLabel;
    private TextBox residentSearchProvinceTextBox;
    private Button residentResetFiltersButton;
    private ComboBox residentProfessionComboBox;
    private Label residentProfessionLabel;
    private Label residentSkinColorLabel;
    private ComboBox residentSkinColorComboBox;
    private DateTimePicker residentSearchToDateTimePicker;
    private Label residentSearchToLabel;
    private Label residentSearchFromLabel;
    private DateTimePicker residentSearchFromDateTimePicker;
    private Button applayDateFilterButton;
}