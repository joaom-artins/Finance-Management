using System.Text.Json.Serialization;

namespace Finance_management.Model;

public class Person
{
    public int Íd { get; set; }
    public string? Name { get; set; }
    public double Salary  { get; set; }
    public string? Job { get; set; }
    [JsonIgnore]
    public Finance Finances { get; set; }
}
