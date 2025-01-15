namespace ResidentBrowser.WinForms.Forms.ExportForms;

partial class ExportForm
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
        exportByProvinceButton = new Button();
        residentProvinceLabel = new Label();
        residentProvinceComboBox = new ComboBox();
        SuspendLayout();
        // 
        // exportByProvinceButton
        // 
        exportByProvinceButton.Location = new Point(387, 311);
        exportByProvinceButton.Name = "exportByProvinceButton";
        exportByProvinceButton.Size = new Size(119, 29);
        exportByProvinceButton.TabIndex = 2;
        exportByProvinceButton.Text = "Export";
        exportByProvinceButton.UseVisualStyleBackColor = true;
        exportByProvinceButton.Click += exportByProvinceButton_Click;
        // 
        // residentProvinceLabel
        // 
        residentProvinceLabel.AutoSize = true;
        residentProvinceLabel.Location = new Point(416, 126);
        residentProvinceLabel.Name = "residentProvinceLabel";
        residentProvinceLabel.Size = new Size(59, 15);
        residentProvinceLabel.TabIndex = 23;
        residentProvinceLabel.Text = "Province :";
        // 
        // residentProvinceComboBox
        // 
        residentProvinceComboBox.FormattingEnabled = true;
        residentProvinceComboBox.Location = new Point(373, 144);
        residentProvinceComboBox.Name = "residentProvinceComboBox";
        residentProvinceComboBox.Size = new Size(147, 23);
        residentProvinceComboBox.TabIndex = 22;
        // 
        // ExportForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 561);
        Controls.Add(residentProvinceLabel);
        Controls.Add(residentProvinceComboBox);
        Controls.Add(exportByProvinceButton);
        Name = "ExportForm";
        Text = "ExportForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button exportByProvinceButton;
    private Label residentProvinceLabel;
    private ComboBox residentProvinceComboBox;
}