using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;

public interface IResidentRepository
{
    Task<List<Resident>> GetResidentListAsync();
    Task<Resident> GetResidentByIdAsync(int id);
    Task CreateResident(Resident resident);
    Task DeleteResident(int id);
}
