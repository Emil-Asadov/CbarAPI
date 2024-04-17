using System.Text.Json.Serialization;

namespace WebApplicationCbarAPI.Models
{
    public class ServiceFields
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("valuteCode")]
        public string ValuteCode { get; set; }

        [JsonPropertyName("nominal")]
        public string Nominal { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
