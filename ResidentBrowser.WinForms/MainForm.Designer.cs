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
        exportsButton = new Button();
        residentsButton = new Button();
        panel1 = new Panel();
        currentViewPanel = new Panel();
        navigationPanel.SuspendLayout();
        SuspendLayout();
        // 
        // navigationPanel
        // 
        navigationPanel.BackColor = Color.MidnightBlue;
        navigationPanel.Controls.Add(exportsButton);
        navigationPanel.Controls.Add(residentsButton);
        navigationPanel.Controls.Add(panel1);
        navigationPanel.Dock = DockStyle.Left;
        navigationPanel.Location = new Point(0, 0);
        navigationPanel.Name = "navigationPanel";
        navigationPanel.Size = new Size(200, 591);
        navigationPanel.TabIndex = 0;
        // 
        // exportsButton
        // 
        exportsButton.BackColor = Color.MidnightBlue;
        exportsButton.Dock = DockStyle.Top;
        exportsButton.FlatAppearance.BorderSize = 0;
        exportsButton.FlatStyle = FlatStyle.Flat;
        exportsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        exportsButton.ForeColor = Color.White;
        exportsButton.Image = Properties.Resources.reports;
        exportsButton.ImageAlign = ContentAlignment.MiddleLeft;
        exportsButton.Location = new Point(0, 151);
        exportsButton.Name = "exportsButton";
        exportsButton.Size = new Size(200, 75);
        exportsButton.TabIndex = 3;
        exportsButton.Text = "Exports";
        exportsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        exportsButton.UseVisualStyleBackColor = false;
        exportsButton.Click += exportsButton_Click;
        // 
        // residentsButton
        // 
        residentsButton.BackColor = Color.MidnightBlue;
        residentsButton.Dock = DockStyle.Top;
        residentsButton.FlatAppearance.BorderSize = 0;
        residentsButton.FlatStyle = FlatStyle.Flat;
        residentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        residentsButton.ForeColor = Color.White;
        residentsButton.Image = Properties.Resources.residents;
        residentsButton.ImageAlign = ContentAlignment.MiddleLeft;
        residentsButton.Location = new Point(0, 76);
        residentsButton.Name = "residentsButton";
        residentsButton.RightToLeft = RightToLeft.No;
        residentsButton.Size = new Size(200, 75);
        residentsButton.TabIndex = 1;
        residentsButton.Text = "Residents";
        residentsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        residentsButton.UseVisualStyleBackColor = false;
        residentsButton.Click += residentsButton_Click;
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
        // currentViewPanel
        // 
        currentViewPanel.Location = new Point(199, 0);
        currentViewPanel.Name = "currentViewPanel";
        currentViewPanel.Size = new Size(925, 600);
        currentViewPanel.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1124, 591);
        Controls.Add(currentViewPanel);
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
    private Button exportsButton;
    private Panel currentViewPanel;
}
