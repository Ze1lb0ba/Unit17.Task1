public class SallarryClass : ITyperOfAccount
{
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.5;
    }
}