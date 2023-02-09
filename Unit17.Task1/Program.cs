internal class Program
{
    private static void Main(string[] args)
    {
        Account myaccount = new Account()
        {
            Type = "Зарплатный",
            Balance = 1000,
            Interest = 10
        };
        AccountCheck(myaccount);

        Console.WriteLine(myaccount.Interest.ToString());
    }

    public static void AccountCheck(Account account)
    {
        if(account.Type == "Обычный")
        {
            var acc = new BasicClass();

            (acc as ITyperOfAccount).CalculateInterest(account);
        }

        if(account.Type == "Зарплатный")
        {
            var acc = new SallarryClass();

            (acc as ITyperOfAccount).CalculateInterest(account);
        }
    }
}
