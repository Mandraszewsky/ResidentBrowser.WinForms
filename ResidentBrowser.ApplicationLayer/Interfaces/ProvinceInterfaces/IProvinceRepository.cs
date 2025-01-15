using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;

public interface IProvinceRepository
{
    Task<List<Province>> GetProvinceListAsync();
}
