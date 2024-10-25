namespace DataWappi.Models;

public interface IDirectvCustomersRepository
{
    public IEnumerable<DirectvCustomers>? GetAll(int[] heardersIndex, string fileName);
    public void AddAll(IEnumerable<DirectvCustomers> entities, string[] headers, string fileName);

}
