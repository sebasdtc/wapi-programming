namespace DataWappi.Models;

public class DirectvCustomers
{
    public string Codigo { get; set; } = string.Empty;
    public string Names { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public List<string> MessageWappi { get; set; } = new List<string>();

    public string[][] ConvertMatrix()
    {
        string[][] matrix = new string[MessageWappi.Count][];

        for(int i = 0; i < MessageWappi.Count; i++)
        {
            matrix[i] = new string[]
            {
                Codigo,
                Names,
                Status,
                District,
                City,
                MessageWappi[i]
            };
        }
        return matrix;
    }

}
