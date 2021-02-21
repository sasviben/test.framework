using Newtonsoft.Json;

namespace UI.Backend.Models
{
    class PlayerBalanceResponse
    {
        public bool Error { get; set; }
        public string Notice { get; set; }
        [JsonProperty(PropertyName = "Data")]
        public PlayerRecord PlayerRecord { get; set; }
    }
}
