using System.Text.Json.Serialization;

namespace Finance_management.Model
{
    public class Finance
    {
        public int Id { get; set; }
        public double Debts { get; set; }
        public double EmergencyReserve { get; set; }
        public double MoneyInvested { get; set; }
        public int PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }

    }
}
