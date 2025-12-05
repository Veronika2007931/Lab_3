


namespace UserClass{
    public class User
    {
        public string Name {get; set;}
        public decimal MoneyAmount {get; set;}

        public User(string name, decimal moneyAmount)
        {
            Name = name;
            MoneyAmount = moneyAmount;
        }
    }
}