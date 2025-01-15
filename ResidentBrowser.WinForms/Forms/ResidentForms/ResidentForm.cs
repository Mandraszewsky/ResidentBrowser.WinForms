using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.DomainLayer.Enums;
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
        FillProfessionComboBox();
        FillSkinColorComboBox();
    }

    private async void FillResidentsGridView()
    {
        residentList = await _residentService.GetResidentListAsync();

        bindingSource.DataSource = residentList;
        residentsDataGridView.DataSource = bindingSource;
    }

    private void FillProfessionComboBox()
    {
        foreach (ResidentProfessionEnum profession in Enum.GetValues(typeof(ResidentProfessionEnum)))
        {
            residentProfessionComboBox.Items.Add(profession);
        }
    }

    private void FillSkinColorComboBox()
    {
        foreach (ResidentSkinColorEnum skinColor in Enum.GetValues(typeof(ResidentSkinColorEnum)))
        {
            residentSkinColorComboBox.Items.Add(skinColor);
        }
    }

    private void ResidentForm_Activated(object sender, EventArgs e)
    {
        FillResidentsGridView();
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillResidentsGridView();
    }

    private void addResidentButton_Click(object sender, EventArgs e)
    {
        AddResidentForm addResidentForm = Program.ServiceProvider!.GetRequiredService<AddResidentForm>();

        addResidentForm.FormClosed += ChildForm_FormClosed!;
        addResidentForm.ShowDialog();
    }

    private async void removeResidentButton_Click(object sender, EventArgs e)
    {
        var residentId = (int)residentsDataGridView.CurrentRow.Cells[0].Value;
        var residentName = $"{(string)residentsDataGridView.CurrentRow.Cells[1].Value} {(string)residentsDataGridView.CurrentRow.Cells[2].Value}";

        var result = MessageBox.Show($"Are you sure that you want to delete resident named: {residentName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            await _residentService.DeleteResident(residentId);

            FillResidentsGridView();
        }
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

    private void residentComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        var filterList = bindingSource.DataSource as List<Resident>;

        var filterProfessionText = residentProfessionComboBox.Text;
        var filterSkinColorText = residentSkinColorComboBox.Text;

        if (!string.IsNullOrWhiteSpace(filterProfessionText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.Profession.ToString().Equals(filterProfessionText, StringComparison.OrdinalIgnoreCase)).ToList();

        if (!string.IsNullOrWhiteSpace(filterSkinColorText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.SkinColor.ToString().Equals(filterSkinColorText, StringComparison.OrdinalIgnoreCase)).ToList();

        bindingSource.DataSource = filterList;
    }
}
