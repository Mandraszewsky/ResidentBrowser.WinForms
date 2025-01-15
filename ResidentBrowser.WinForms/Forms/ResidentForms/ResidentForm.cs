using Microsoft.IdentityModel.Tokens;
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

    private void residentTextBoxFilter_TextChanged(object sender, EventArgs e)
    {
        var filterList = bindingSource.DataSource as List<Resident>;

        var filterNameText = residentSearchNameTextBox.Text.ToLower();
        var filterPESELText = residentSearchPESELTextBox.Text.ToLower();
        var filterProvinceText = residentSearchProvinceTextBox.Text.ToLower();

        if (!string.IsNullOrWhiteSpace(filterNameText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.LastName!.ToLower().Contains(filterNameText)).ToList();

        if (!string.IsNullOrWhiteSpace(filterPESELText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.PESEL!.ToLower().Contains(filterPESELText)).ToList();

        if (!string.IsNullOrWhiteSpace(filterProvinceText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.Province!.ToLower().Contains(filterProvinceText)).ToList();

        bindingSource.DataSource = filterList;

        if (string.IsNullOrWhiteSpace(filterNameText) && string.IsNullOrWhiteSpace(filterPESELText) && string.IsNullOrWhiteSpace(filterProvinceText))
            bindingSource.DataSource = residentList;
        else
            bindingSource.DataSource = filterList;

    }

    private void applayDateFilterButton_Click(object sender, EventArgs e)
    {
        var filterList = bindingSource.DataSource as List<Resident>;

        var filterFromDate = residentSearchFromDateTimePicker.Value;
        var filterToDate = residentSearchToDateTimePicker.Value;

        if (!filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.BirthDate >= filterFromDate && x.BirthDate <= filterToDate).ToList();

        bindingSource.DataSource = filterList;
    }

    private void residentResetFiltersButton_Click(object sender, EventArgs e)
    {
        residentSearchNameTextBox.Text = string.Empty;
        residentSearchPESELTextBox.Text = string.Empty;
        residentSearchProvinceTextBox.Text = string.Empty;

        residentSearchFromDateTimePicker.Value = DateTime.Now;
        residentSearchToDateTimePicker.Value = DateTime.Now;

        bindingSource.DataSource = residentList;
    }
}
