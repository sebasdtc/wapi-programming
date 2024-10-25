using ClosedXML.Excel;
using DataWappi.Models;

namespace DataWappi.Lib;

public static class ExcelHelper
{
    #region Read Excel columnName
    /// <summary>
    /// Este método lee un archivo de Excel y devuelve una lista de cadenas de texto que contienen
    /// </summary>
    /// <param name="columnName">los valores de las celdas de las columnas especificadas en el parámetro 'columnName'.</param>
    /// <returns>Retorna una lista de tipo StringBuilder concatenada con el delimitador establecido</returns>
    public static List<DirectvCustomers>? GetExcelData(int[] columnIndex, string fileName)
    {
        try
        {
            // abre el archivo de Excel
            using XLWorkbook workbook = new(fileName);

            // Obtiene la primera hoja de cálculo del libro
            IXLWorksheet worksheet = workbook.Worksheet(1);

            // Crea una lista vacía que se usará para almacenar los datos leídos del archivo de Excel
            List<DirectvCustomers> data = new();

            // Obtiene una colección de todas las filas de la hoja de cálculo que contienen datos
            var rows = worksheet.RangeUsed().Rows();

            // Itera sobre las filas de la hoja de cálculo
            foreach(var row in rows)
            {
                // Get a collection of all cells in the current row
                var cells = row.Cells();

                // Create a new DirectvCutomers object
                DirectvCustomers customer = new()
                {
                    Codigo = cells.ElementAt(columnIndex[0]).Value.ToString(),
                    Names = cells.ElementAt(columnIndex[1]).Value.ToString(),
                    Status = cells.ElementAt(columnIndex[2]).Value.ToString(),
                    District = cells.ElementAt(columnIndex[3]).Value.ToString(),
                    City = cells.ElementAt(columnIndex[4]).Value.ToString(),
                    PhoneNumber = cells.ElementAt(columnIndex[5]).Value.ToString(),
                };

                // Add the DirectvCutomers object to the list of results
                data.Add(customer);

            }
            // Elimina los objetos duplicados de la lista y devuelve una lista única
            List<DirectvCustomers> uniqueData = data.DistinctBy(c => c.Codigo).ToList();

            // Retorna la lista única
            return uniqueData;
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine($"El archivo '{fileName}' no se encontró.");
        }
        catch(FormatException)
        {
            Console.WriteLine($"El archivo '{fileName}' no tiene el formato correcto.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Se ha producido una excepción: " + ex.Message);
        }

        return null;
    }
    #endregion

    #region Export Excel columnName Data
    /// <summary>
    /// Método que exporta un excel
    /// </summary>
    /// <param name="data">Lista de los datos que se usara para exportar</param>
    /// <param name="headers">Representa el encabezado de la tabla de excel</param>
    /// <param name="fileName">Nombre del archivo excel a exportar</param>
    /// de la tabla</param>
    public static void ExportExcelData(List<DirectvCustomers> data, string[] headers, string fileName)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Hoja1");

        // Escribir los títulos de las columnas
        for(int i = 0; i < headers.Length; i++)
        {
            worksheet.Cell(1, i + 1).Value = headers[i];
        }

        // Escribir los datos de la lista en las filas siguientes
        var rowData = data.SelectMany(d => d.ConvertMatrix()).ToArray();

        // Escribir los datos de la matriz en las filas siguientes
        worksheet.Cell(2, 1).InsertData(rowData);

        worksheet.Columns().AdjustToContents();
        // Guardar el archivo
        workbook.SaveAs(fileName);
    }
    #endregion
}
