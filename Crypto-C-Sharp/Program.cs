using System;

namespace CryptoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockchain = new Blockchain();

            blockchain.CreateTransaction(new Transaction(null, "address1", 100));
            blockchain.CreateTransaction(new Transaction("address1", "address2", 50));
            blockchain.CreateTransaction(new Transaction("address2", "address1", 10));



            blockchain.MinePendingTransactions("Jardine-Address");

            Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));

            blockchain.MinePendingTransactions("Jardine-Address");

            Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));
            Console.WriteLine("Balance of address1: " + blockchain.GetAddressBalance("address1"));
            Console.WriteLine("Balance of address2: " + blockchain.GetAddressBalance("address2"));

            blockchain.CreateTransaction(new Transaction("Jardine-Address", "address2", 50));
            blockchain.MinePendingTransactions("Jardine-Address");

            Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));
            Console.WriteLine("Balance of address1: " + blockchain.GetAddressBalance("address1"));
            Console.WriteLine("Balance of address2: " + blockchain.GetAddressBalance("address2"));
        }
    }
}
