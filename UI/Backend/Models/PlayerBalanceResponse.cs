using Newtonsoft.Json;
using System.Collections.Generic;

namespace UI.Backend.Models
{
    public class PlayerBalanceResponse
    {
        public bool Error { get; set; }
        public string Notice { get; set; }
        [JsonProperty(PropertyName = "Data")]
        public PlayerRecord PlayerRecord { get; set; }

    }

    public class Account
    {
        public int AccountType { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public int InitiallyLockedAmount { get; set; }
        public int LockedAmount { get; set; }
        public string Name { get; set; }
        public string WagerType { get; set; }
        public string Wagered { get; set; }
        public string WageringRequirement { get; set; }

    }

    public class PlayerRecord
    {
        public string ErrorMessage { get; set; }
        public string StatusCode { get; set; }
        public List<Account> Accounts { get; set; }
        public int RecordCount { get; set; }

    }
}
