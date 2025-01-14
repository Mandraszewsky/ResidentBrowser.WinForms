using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Services;

public class ResidentService : IResidentService
{
    private readonly IResidentRepository _residentRepository;

    public ResidentService(IResidentRepository residentRepository)
    {
        _residentRepository = residentRepository;
    }

    public async Task CreateResident(Resident resident)
    {
        await _residentRepository.CreateResident(resident);
    }

    public async Task DeleteResident(int id)
    {
        await _residentRepository.DeleteResident(id);
    }

    public async Task<Resident> GetResidentByIdAsync(int id)
    {
        return await _residentRepository.GetResidentByIdAsync(id);
    }

    public async Task<List<Resident>> GetResidentListAsync()
    {
        return await _residentRepository.GetResidentListAsync();
    }
}
