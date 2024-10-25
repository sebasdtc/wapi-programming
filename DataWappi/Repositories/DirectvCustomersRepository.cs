using DataWappi.Lib;
using DataWappi.Models;

namespace DataWappi.Repositories;

public class DirectvCustomersRepository : IDirectvCustomersRepository
{
    public void AddAll(IEnumerable<DirectvCustomers> entities, string[] headers, string fileName)
    {
        ExcelHelper.ExportExcelData(entities.ToList(), headers, fileName);
    }

    public IEnumerable<DirectvCustomers>? GetAll(int[] heardersIndex, string fileName)
    {
        return ExcelHelper.GetExcelData(heardersIndex, fileName);
    }
}
