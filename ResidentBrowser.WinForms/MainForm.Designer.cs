namespace ResidentBrowser.WinForms;

partial class MainForm
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
        navigationPanel = new Panel();
        residentsButton = new Button();
        panel1 = new Panel();
        exportButton = new Button();
        navigationPanel.SuspendLayout();
        SuspendLayout();
        // 
        // navigationPanel
        // 
        navigationPanel.BackColor = Color.MidnightBlue;
        navigationPanel.Controls.Add(exportButton);
        navigationPanel.Controls.Add(residentsButton);
        navigationPanel.Controls.Add(panel1);
        navigationPanel.Dock = DockStyle.Left;
        navigationPanel.Location = new Point(0, 0);
        navigationPanel.Name = "navigationPanel";
        navigationPanel.Size = new Size(200, 561);
        navigationPanel.TabIndex = 0;
        // 
        // residentsButton
        // 
        residentsButton.BackColor = Color.MidnightBlue;
        residentsButton.Dock = DockStyle.Top;
        residentsButton.FlatAppearance.BorderSize = 0;
        residentsButton.FlatStyle = FlatStyle.Flat;
        residentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        residentsButton.ForeColor = Color.White;
        residentsButton.Location = new Point(0, 76);
        residentsButton.Name = "residentsButton";
        residentsButton.Size = new Size(200, 75);
        residentsButton.TabIndex = 1;
        residentsButton.Text = "Residents";
        residentsButton.UseVisualStyleBackColor = false;
        // 
        // panel1
        // 
        panel1.BackColor = Color.MidnightBlue;
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 76);
        panel1.TabIndex = 2;
        // 
        // exportButton
        // 
        exportButton.BackColor = Color.MidnightBlue;
        exportButton.Dock = DockStyle.Top;
        exportButton.FlatAppearance.BorderSize = 0;
        exportButton.FlatStyle = FlatStyle.Flat;
        exportButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        exportButton.ForeColor = Color.White;
        exportButton.Location = new Point(0, 151);
        exportButton.Name = "exportButton";
        exportButton.Size = new Size(200, 75);
        exportButton.TabIndex = 3;
        exportButton.Text = "Exports";
        exportButton.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 561);
        Controls.Add(navigationPanel);
        Name = "MainForm";
        Text = "Resident Browser";
        navigationPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel navigationPanel;
    private Button residentsButton;
    private Panel panel1;
    private Button exportButton;
}
