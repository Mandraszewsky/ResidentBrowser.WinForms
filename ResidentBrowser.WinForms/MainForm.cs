using Microsoft.Extensions.DependencyInjection;
using ResidentBrowser.WinForms.Forms.ExportForms;
using ResidentBrowser.WinForms.Forms.ResidentForms;

namespace ResidentBrowser.WinForms;

public partial class MainForm : Form
{
    private Button currentButton;
    private Form activeForm;

    public MainForm()
    {
        currentButton = new Button();
        activeForm = new Form();

        InitializeComponent();
    }

    private void ActivateButton(object sender, EventArgs e)
    {
        if (sender != null)
        {
            if (currentButton != (Button)sender)
            {
                DisactivateButtons();
                currentButton = (Button)sender;
                currentButton.BackColor = Color.DarkBlue;
                currentButton.Font = new Font("Segoe UI Semibold", 13.50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
    }

    private void DisactivateButtons()
    {
        foreach (Control button in navigationPanel.Controls)
        {
            if (button.GetType() == typeof(Button))
            {
                button.BackColor = Color.MidnightBlue;
                button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
    }

    private void OpenChildForm(Form childForm, object sender, EventArgs e)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }

        ActivateButton(sender, e);
        activeForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        this.currentViewPanel.Controls.Add(childForm);
        this.currentViewPanel.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
        childForm.Focus();
    }

    private void residentsButton_Click(object sender, EventArgs e)
    {
        ResidentForm residentForm = Program.ServiceProvider!.GetRequiredService<ResidentForm>();
        OpenChildForm(residentForm, sender, e);

    }

    private void exportsButton_Click(object sender, EventArgs e)
    {
        ExportForm exportForm = Program.ServiceProvider!.GetRequiredService<ExportForm>();
        OpenChildForm(exportForm, sender, e);
    }
}
