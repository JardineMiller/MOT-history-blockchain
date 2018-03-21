using System;
namespace CryptoCSharp
{
    public class Transaction
    {
        public readonly string CarRegistration;
        public readonly MOT MOT;

        public Transaction(string carRegistration, MOT mot)
        {
            CarRegistration = carRegistration;
            MOT = mot;
        }
    }
}
