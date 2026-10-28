namespace csharp_homework10;

public class CreditCard
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public DateTime CardExpirationDate { get; set; }
    public string PIN { get; set; }
    public decimal CreditLimit { get; set; }
    public decimal Balance { get; set; }

    public CreditCard()
    {
        CardNumber = "Default Card Number";
        CardHolderName = "Default Card Holder";
        CardExpirationDate = DateTime.Now.AddYears(10);
        PIN = "00000000";
        CreditLimit = 1;
        Balance = 1;
    }

    public CreditCard(string cardNumber, string cardHolderName, DateTime cardExpirationDate, decimal creditLimit,
        decimal balance)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            throw new ArgumentException($"[EXCEPTION] Card Number cannot be <= 0 ({nameof(cardNumber)})");
        if (string.IsNullOrWhiteSpace(cardHolderName))
            throw new ArgumentException($"[EXCEPTION] Card Holder Name cannot be <= 0 ({nameof(cardHolderName)})");
        
    }
}