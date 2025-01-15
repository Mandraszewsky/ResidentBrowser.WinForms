namespace ResidentBrowser.WinForms.Forms.ResidentForms;

partial class AddResidentForm
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
        residentFirstNameLabel = new Label();
        residentFirstNameTextBox = new TextBox();
        residentLastNameLabel = new Label();
        residentLastNameTextBox = new TextBox();
        residentPESELLabel = new Label();
        residentPESELTextBox = new TextBox();
        residentSkinColorLabel = new Label();
        residentSkinColorComboBox = new ComboBox();
        residentProfessionLabel = new Label();
        residentProfessionComboBox = new ComboBox();
        residentBirthDateLabel = new Label();
        residentBirthDateTimePicker = new DateTimePicker();
        residentProvinceLabel = new Label();
        residentProvinceComboBox = new ComboBox();
        addResidentButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // residentFirstNameLabel
        // 
        residentFirstNameLabel.AutoSize = true;
        residentFirstNameLabel.Location = new Point(98, 49);
        residentFirstNameLabel.Name = "residentFirstNameLabel";
        residentFirstNameLabel.Size = new Size(70, 15);
        residentFirstNameLabel.TabIndex = 6;
        residentFirstNameLabel.Text = "First Name :";
        // 
        // residentFirstNameTextBox
        // 
        residentFirstNameTextBox.Location = new Point(174, 46);
        residentFirstNameTextBox.Name = "residentFirstNameTextBox";
        residentFirstNameTextBox.Size = new Size(190, 23);
        residentFirstNameTextBox.TabIndex = 5;
        // 
        // residentLastNameLabel
        // 
        residentLastNameLabel.AutoSize = true;
        residentLastNameLabel.Location = new Point(98, 87);
        residentLastNameLabel.Name = "residentLastNameLabel";
        residentLastNameLabel.Size = new Size(69, 15);
        residentLastNameLabel.TabIndex = 8;
        residentLastNameLabel.Text = "Last Name :";
        // 
        // residentLastNameTextBox
        // 
        residentLastNameTextBox.Location = new Point(174, 84);
        residentLastNameTextBox.Name = "residentLastNameTextBox";
        residentLastNameTextBox.Size = new Size(190, 23);
        residentLastNameTextBox.TabIndex = 7;
        // 
        // residentPESELLabel
        // 
        residentPESELLabel.AutoSize = true;
        residentPESELLabel.Location = new Point(123, 125);
        residentPESELLabel.Name = "residentPESELLabel";
        residentPESELLabel.Size = new Size(44, 15);
        residentPESELLabel.TabIndex = 10;
        residentPESELLabel.Text = "PESEL :";
        // 
        // residentPESELTextBox
        // 
        residentPESELTextBox.Location = new Point(174, 122);
        residentPESELTextBox.Name = "residentPESELTextBox";
        residentPESELTextBox.Size = new Size(190, 23);
        residentPESELTextBox.TabIndex = 9;
        // 
        // residentSkinColorLabel
        // 
        residentSkinColorLabel.AutoSize = true;
        residentSkinColorLabel.Location = new Point(103, 208);
        residentSkinColorLabel.Name = "residentSkinColorLabel";
        residentSkinColorLabel.Size = new Size(65, 15);
        residentSkinColorLabel.TabIndex = 17;
        residentSkinColorLabel.Text = "Skin color :";
        // 
        // residentSkinColorComboBox
        // 
        residentSkinColorComboBox.FormattingEnabled = true;
        residentSkinColorComboBox.Location = new Point(174, 205);
        residentSkinColorComboBox.Name = "residentSkinColorComboBox";
        residentSkinColorComboBox.Size = new Size(147, 23);
        residentSkinColorComboBox.TabIndex = 16;
        // 
        // residentProfessionLabel
        // 
        residentProfessionLabel.AutoSize = true;
        residentProfessionLabel.Location = new Point(100, 164);
        residentProfessionLabel.Name = "residentProfessionLabel";
        residentProfessionLabel.Size = new Size(68, 15);
        residentProfessionLabel.TabIndex = 15;
        residentProfessionLabel.Text = "Profession :";
        // 
        // residentProfessionComboBox
        // 
        residentProfessionComboBox.FormattingEnabled = true;
        residentProfessionComboBox.Location = new Point(174, 161);
        residentProfessionComboBox.Name = "residentProfessionComboBox";
        residentProfessionComboBox.Size = new Size(147, 23);
        residentProfessionComboBox.TabIndex = 14;
        // 
        // residentBirthDateLabel
        // 
        residentBirthDateLabel.AutoSize = true;
        residentBirthDateLabel.Location = new Point(103, 293);
        residentBirthDateLabel.Name = "residentBirthDateLabel";
        residentBirthDateLabel.Size = new Size(65, 15);
        residentBirthDateLabel.TabIndex = 19;
        residentBirthDateLabel.Text = "Birth Date :";
        // 
        // residentBirthDateTimePicker
        // 
        residentBirthDateTimePicker.Format = DateTimePickerFormat.Short;
        residentBirthDateTimePicker.Location = new Point(174, 287);
        residentBirthDateTimePicker.Name = "residentBirthDateTimePicker";
        residentBirthDateTimePicker.Size = new Size(100, 23);
        residentBirthDateTimePicker.TabIndex = 18;
        // 
        // residentProvinceLabel
        // 
        residentProvinceLabel.AutoSize = true;
        residentProvinceLabel.Location = new Point(109, 248);
        residentProvinceLabel.Name = "residentProvinceLabel";
        residentProvinceLabel.Size = new Size(59, 15);
        residentProvinceLabel.TabIndex = 21;
        residentProvinceLabel.Text = "Province :";
        // 
        // residentProvinceComboBox
        // 
        residentProvinceComboBox.FormattingEnabled = true;
        residentProvinceComboBox.Location = new Point(174, 245);
        residentProvinceComboBox.Name = "residentProvinceComboBox";
        residentProvinceComboBox.Size = new Size(147, 23);
        residentProvinceComboBox.TabIndex = 20;
        // 
        // addResidentButton
        // 
        addResidentButton.Location = new Point(243, 375);
        addResidentButton.Name = "addResidentButton";
        addResidentButton.Size = new Size(121, 37);
        addResidentButton.TabIndex = 22;
        addResidentButton.Text = "Add";
        addResidentButton.UseVisualStyleBackColor = true;
        addResidentButton.Click += addResidentButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(408, 375);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(121, 37);
        cancelButton.TabIndex = 23;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // AddResidentForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(564, 441);
        Controls.Add(cancelButton);
        Controls.Add(addResidentButton);
        Controls.Add(residentProvinceLabel);
        Controls.Add(residentProvinceComboBox);
        Controls.Add(residentBirthDateLabel);
        Controls.Add(residentBirthDateTimePicker);
        Controls.Add(residentSkinColorLabel);
        Controls.Add(residentSkinColorComboBox);
        Controls.Add(residentProfessionLabel);
        Controls.Add(residentProfessionComboBox);
        Controls.Add(residentPESELLabel);
        Controls.Add(residentPESELTextBox);
        Controls.Add(residentLastNameLabel);
        Controls.Add(residentLastNameTextBox);
        Controls.Add(residentFirstNameLabel);
        Controls.Add(residentFirstNameTextBox);
        Name = "AddResidentForm";
        Text = "Add New Resident";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label residentFirstNameLabel;
    private TextBox residentFirstNameTextBox;
    private Label residentLastNameLabel;
    private TextBox residentLastNameTextBox;
    private Label residentPESELLabel;
    private TextBox residentPESELTextBox;
    private Label residentSkinColorLabel;
    private ComboBox residentSkinColorComboBox;
    private Label residentProfessionLabel;
    private ComboBox residentProfessionComboBox;
    private Label residentBirthDateLabel;
    private DateTimePicker residentBirthDateTimePicker;
    private Label residentProvinceLabel;
    private ComboBox residentProvinceComboBox;
    private Button addResidentButton;
    private Button cancelButton;
}