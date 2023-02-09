public class BasicClass : ITyperOfAccount
{
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.4;

        if (account.Balance < 1000)
            account.Interest -= account.Balance * 0.2;

        if (account.Balance < 50000)
            account.Interest -= account.Balance * 0.4;
    }
}
