using ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Services;

public class ProvinceService : IProvinceService
{
    private readonly IProvinceRepository _provinceRepository;

    public ProvinceService(IProvinceRepository provinceRepository)
    {
        _provinceRepository = provinceRepository;
    }

    public async Task<List<Province>> GetProvinceListAsync()
    {
        return await _provinceRepository.GetProvinceListAsync();
    }
}
