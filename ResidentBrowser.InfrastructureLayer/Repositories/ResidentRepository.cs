using Microsoft.Data.SqlClient;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.ApplicationLayer.Utilities;
using ResidentBrowser.DomainLayer.Enums;
using ResidentBrowser.DomainLayer.Models;
using ResidentBrowser.InfrastructureLayer.Data;
using System.Collections.Generic;

namespace ResidentBrowser.InfrastructureLayer.Repositories;

public class ResidentRepository : IResidentRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task CreateResident(Resident resident)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "INSERT INTO Osoby (ID_Osoby, Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, ID_Wojewodztwa, Zawod) VALUES (@Id, @FirstName, @LastName, @PESEL, @BirthDate, @SkinColor, @Province, @Profession)";

        var skinColorName = EnumHelper.GetDescription<ResidentSkinColorEnum>((ResidentSkinColorEnum)resident.SkinColor!);
        var professionName = EnumHelper.GetDescription<ResidentProfessionEnum>((ResidentProfessionEnum)resident.Profession!);

        var command = new SqlCommand(querySQL, conn);

        command.Parameters.Add(new SqlParameter("@Id", resident.Id));
        command.Parameters.Add(new SqlParameter("@FirstName", resident.FirstName));
        command.Parameters.Add(new SqlParameter("@LastName", resident.LastName));
        command.Parameters.Add(new SqlParameter("@PESEL", resident.PESEL));
        command.Parameters.Add(new SqlParameter("@Province", Convert.ToInt32(resident.Province)));
        command.Parameters.Add(new SqlParameter("@BirthDate", resident.BirthDate));
        command.Parameters.Add(new SqlParameter("@SkinColor", skinColorName));
        command.Parameters.Add(new SqlParameter("@Profession", professionName));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Task DeleteResident(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Resident> GetResidentByIdAsync(int id)
    {
        var resident = new Resident();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT o.ID_Osoby, o.Imie, o.Nazwisko, o.PESEL, o.DataUrodzenia, o.KolorSkory, o.Zawod, w.NazwaWojewodztwa FROM Osoby o INNER JOIN Wojewodztwa w ON o.ID_Wojewodztwa = w.ID_Wojewodztwa WHERE ID_Osoby = '{id}'";

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
                    resident.Province = dataReader["NazwaWojewodztwa"].ToString();
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

    public async Task<int> GetResidentLastIdAsync()
    {
        var lastId = new int();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT MAX(ID_Osoby) AS LastId FROM Osoby;";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    lastId = Convert.ToInt32(dataReader["LastId"]);
                }
            }

            await conn.CloseAsync();

            return lastId;

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

        string querySQL = "SELECT o.ID_Osoby, o.Imie, o.Nazwisko, o.PESEL, o.DataUrodzenia, o.KolorSkory, o.Zawod, w.NazwaWojewodztwa FROM Osoby o INNER JOIN Wojewodztwa w ON o.ID_Wojewodztwa = w.ID_Wojewodztwa;";

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
                    resident.Province = dataReader["NazwaWojewodztwa"].ToString();
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
