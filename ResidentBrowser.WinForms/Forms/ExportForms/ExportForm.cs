using ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.ApplicationLayer.Utilities;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.WinForms.Forms.ExportForms;

public partial class ExportForm : Form
{
    private readonly IResidentService _residentService;
    private readonly IProvinceService _provinceService;

    public ExportForm(IResidentService residentService, IProvinceService provinceService)
    {
        _residentService = residentService;
        _provinceService = provinceService;

        InitializeComponent();
        FillProvinceComboBox();
    }

    private async void FillProvinceComboBox()
    {
        var provinces = new List<Province>();

        provinces = await _provinceService.GetProvinceListAsync();

        foreach (var province in provinces)
        {
            residentProvinceComboBox.Items.Add(province.Name!);
        }

        residentProvinceComboBox.SelectedIndex = 0;
    }

    private async void exportByProvinceButton_Click(object sender, EventArgs e)
    {
        // due to lack of time such a solution (not optimal)
        var residentList = await _residentService.GetResidentListAsync();
        var provinceName = residentProvinceComboBox.Text;

        residentList = residentList.Where(x => x.Province!.Equals(provinceName)).ToList();

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataByProvince.xlsx");
        var result = ExportHelper.ExportToExcel(residentList, filePath);

        if (result)
            MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("An error occurred during export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
