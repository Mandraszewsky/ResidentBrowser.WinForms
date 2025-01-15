using ResidentBrowser.DomainLayer.Enums;

namespace ResidentBrowser.DomainLayer.Models;

public class Resident
{
    public int Id { get; set; } = default!;
    public string? FirstName { get; set; } = default!;
    public string? LastName { get; set; } = default!;
    public string? PESEL { get; set; } = default!;
    public string? Province { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;
    public ResidentSkinColorEnum? SkinColor { get; set; } = default!;
    public ResidentProfessionEnum? Profession { get; set; } = default!;

}
