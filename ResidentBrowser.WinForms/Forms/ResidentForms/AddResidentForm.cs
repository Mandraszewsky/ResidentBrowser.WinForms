using ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.DomainLayer.Enums;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.WinForms.Forms.ResidentForms;

public partial class AddResidentForm : Form
{
    private readonly IResidentService _residentService;
    private readonly IProvinceService _provinceService;

    private List<Province> provinceList = new List<Province>();

    public AddResidentForm(IResidentService residentService, IProvinceService provinceService)
    {
        _residentService = residentService;
        _provinceService = provinceService;

        InitializeComponent();
        FillProfessionComboBox();
        FillSkinColorComboBox();
        FillProvinceComboBox();
    }

    private void FillProfessionComboBox()
    {
        foreach (ResidentProfessionEnum profession in Enum.GetValues(typeof(ResidentProfessionEnum)))
        {
            residentProfessionComboBox.Items.Add(profession);
        }

        residentProfessionComboBox.SelectedIndex = 0;
    }

    private void FillSkinColorComboBox()
    {
        foreach (ResidentSkinColorEnum skinColor in Enum.GetValues(typeof(ResidentSkinColorEnum)))
        {
            residentSkinColorComboBox.Items.Add(skinColor);
        }

        residentSkinColorComboBox.SelectedIndex = 0;
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
        provinceList = provinces;
    }

    private async void addResidentButton_Click(object sender, EventArgs e)
    {
        var provinceName = residentProvinceComboBox.Text;
        var provinceId = provinceList.FirstOrDefault(x => x.Name!.Equals(provinceName))!.Id.ToString();

        var resident = new Resident
        {
            FirstName = residentFirstNameTextBox.Text,
            LastName = residentLastNameTextBox.Text,
            PESEL = residentPESELTextBox.Text,
            Province = provinceId,
            BirthDate = residentBirthDateTimePicker.Value,
            SkinColor = (ResidentSkinColorEnum)Enum.Parse(typeof(ResidentSkinColorEnum), residentSkinColorComboBox.Text),
            Profession = (ResidentProfessionEnum)Enum.Parse(typeof(ResidentProfessionEnum), residentProfessionComboBox.Text)
        };

        var lastResidentId = await _residentService.GetResidentLastIdAsync();
        resident.Id = lastResidentId + 1;

        await _residentService.CreateResident(resident);

        this.Close();
    }
}
