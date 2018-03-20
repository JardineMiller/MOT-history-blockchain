using System;
namespace CryptoCSharp
{
    public class Transaction
    {
        public readonly string FromAddress;
        public readonly string ToAddress;
        public readonly float Amount;

        public Transaction(string fromAddress, string toAddress, float amount)
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            Amount = amount;
        }
    }
}
