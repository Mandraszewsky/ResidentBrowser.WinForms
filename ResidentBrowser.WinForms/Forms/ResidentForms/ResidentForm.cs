using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.WinForms.Forms.ResidentForms;

public partial class ResidentForm : Form
{
    private readonly IResidentService _residentService;

    private List<Resident> residentList = new List<Resident>();
    private BindingSource bindingSource = new BindingSource();

    public ResidentForm(IResidentService residentService)
    {
        _residentService = residentService;

        InitializeComponent();
        FillResidentsGridView();
    }

    private async void FillResidentsGridView()
    {
        residentList = await _residentService.GetResidentListAsync();

        bindingSource.DataSource = residentList;
        residentsDataGridView.DataSource = bindingSource;
    }

    private void ResidentForm_Activated(object sender, EventArgs e)
    {
        FillResidentsGridView();
    }
}
