using System.Collections.Generic;

namespace UI.Backend.Models
{
    public class PlayerRecord
    {
        public string ErrorMessage { get; set; }
        public string StatusCode { get; set; }
        public List<Account> Accounts { get; set; }
        public int RecordCount { get; set; }
    }
}
