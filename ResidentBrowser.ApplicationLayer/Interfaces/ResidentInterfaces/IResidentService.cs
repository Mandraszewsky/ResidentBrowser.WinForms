using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;

public interface IResidentService
{
    Task<List<Resident>> GetResidentListAsync();
    Task<Resident> GetResidentByIdAsync(int id);
    Task<int> GetResidentLastIdAsync();
    Task CreateResident(Resident resident);
    Task DeleteResident(int id);

}
