using System.ComponentModel;

namespace ResidentBrowser.DomainLayer.Enums;

public enum ResidentSkinColorEnum
{
    [Description("Ciemny")]
    Dark = 1,
    [Description("Mieszany")]
    Mixed = 2,
    [Description("Śniady")]
    Pale = 3,
    [Description("Jasny")]
    Light = 4,
}
