using ClosedXML.Excel;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Utilities;

public static class ExportHelper
{
    public static bool ExportToExcel(List<Resident> data, string filePath)
    {
        try
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");

                worksheet.Cell(1, 1).Value = "Id";
                worksheet.Cell(1, 2).Value = "FirstName";
                worksheet.Cell(1, 3).Value = "LastName";
                worksheet.Cell(1, 4).Value = "PESEL";
                worksheet.Cell(1, 5).Value = "Province";
                worksheet.Cell(1, 6).Value = "BirthDate";
                worksheet.Cell(1, 7).Value = "SkinColor";
                worksheet.Cell(1, 8).Value = "Profession";

                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = data[i].Id;
                    worksheet.Cell(i + 2, 2).Value = data[i].FirstName;
                    worksheet.Cell(i + 2, 3).Value = data[i].LastName;
                    worksheet.Cell(i + 2, 4).Value = data[i].PESEL;
                    worksheet.Cell(i + 2, 5).Value = data[i].Province;
                    worksheet.Cell(i + 2, 6).Value = data[i].BirthDate.ToString();
                    worksheet.Cell(i + 2, 7).Value = data[i].SkinColor.ToString();
                    worksheet.Cell(i + 2, 8).Value = data[i].Profession.ToString();
                }

                workbook.SaveAs(filePath);
            }

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
