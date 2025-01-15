using Microsoft.Data.SqlClient;
using ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;
using ResidentBrowser.DomainLayer.Models;
using ResidentBrowser.InfrastructureLayer.Data;

namespace ResidentBrowser.InfrastructureLayer.Repositories;

public class ProvinceRepository : IProvinceRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task<List<Province>> GetProvinceListAsync()
    {
        var provinceList = new List<Province>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT ID_Wojewodztwa, NazwaWojewodztwa FROM Wojewodztwa;";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    var province = new Province();

                    province.Id = Convert.ToInt32(dataReader["ID_Wojewodztwa"]);
                    province.Name = dataReader["NazwaWojewodztwa"].ToString();

                    provinceList.Add(province);
                }
            }

            await conn.CloseAsync();

            return provinceList;

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
