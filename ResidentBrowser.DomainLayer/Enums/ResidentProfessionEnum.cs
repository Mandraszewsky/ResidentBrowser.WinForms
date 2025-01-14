using System.ComponentModel;

namespace ResidentBrowser.DomainLayer.Enums;

public enum ResidentProfessionEnum
{
    [Description("Prawnik")]
    Lawyer = 1,
    [Description("Rolnik")]
    Farmer = 2,
    [Description("Pielęgniarka")]
    Nurse = 3,
    [Description("Kierowca")]
    Driver = 4,
    [Description("Fryzjer")]
    Hairdresser = 5,
    [Description("Mechanik")]
    Mechanic = 6,
    [Description("Informatyk")]
    Developer = 7,
    [Description("Policjant")]
    Policeman = 8,
    [Description("Lekarz")]
    Doctor = 9,
    [Description("Nauczyciel")]
    Teacher = 10,
}
