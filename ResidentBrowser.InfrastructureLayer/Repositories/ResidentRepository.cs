using Microsoft.Data.SqlClient;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.ApplicationLayer.Utilities;
using ResidentBrowser.DomainLayer.Enums;
using ResidentBrowser.DomainLayer.Models;
using ResidentBrowser.InfrastructureLayer.Data;

namespace ResidentBrowser.InfrastructureLayer.Repositories;

public class ResidentRepository : IResidentRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public Task CreateResident(Resident resident)
    {
        throw new NotImplementedException();
    }

    public Task DeleteResident(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Resident> GetResidentByIdAsync(int id)
    {
        var resident = new Resident();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT ID_Osoby, Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, Zawod FROM Osoby WHERE ID_Osoby = '{id}'";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if(dataReader != null)
            {
                while (dataReader.Read())
                {
                    resident.Id = Convert.ToInt32(dataReader["ID_Osoby"]);
                    resident.FirstName = dataReader["Imie"].ToString();
                    resident.LastName = dataReader["Nazwisko"].ToString();
                    resident.PESEL = dataReader["PESEL"].ToString();
                    resident.BirthDate = DateTime.Parse(dataReader["DataUrodzenia"].ToString()!);
                    resident.SkinColor = (ResidentSkinColorEnum)Convert.ToInt32(dataReader["KolorSkory"].ToString());
                    resident.Profession = (ResidentProfessionEnum)Convert.ToInt32(dataReader["Zawod"].ToString());
                }
            }

            await conn.CloseAsync();

            return resident;

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public async Task<List<Resident>> GetResidentListAsync()
    {
        var residentList = new List<Resident>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT ID_Osoby, Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, Zawod FROM Osoby;";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    var resident = new Resident();

                    resident.Id = Convert.ToInt32(dataReader["ID_Osoby"]);
                    resident.FirstName = dataReader["Imie"].ToString();
                    resident.LastName = dataReader["Nazwisko"].ToString();
                    resident.PESEL = dataReader["PESEL"].ToString();
                    resident.BirthDate = DateTime.Parse(dataReader["DataUrodzenia"].ToString()!);

                    var skinColor = EnumHelper.GetEnumValueFromDescription<ResidentSkinColorEnum>(dataReader["KolorSkory"].ToString()!);
                    var profession = EnumHelper.GetEnumValueFromDescription<ResidentProfessionEnum>(dataReader["Zawod"].ToString()!);

                    resident.SkinColor = skinColor;
                    resident.Profession = profession;

                    residentList.Add(resident);
                }
            }

            await conn.CloseAsync();

            return residentList;

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
