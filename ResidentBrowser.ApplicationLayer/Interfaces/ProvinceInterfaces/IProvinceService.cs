using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;

public interface IProvinceService
{
    Task<List<Province>> GetProvinceListAsync();
}
