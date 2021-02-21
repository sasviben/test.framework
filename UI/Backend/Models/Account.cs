namespace UI.Backend.Models
{
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
}
