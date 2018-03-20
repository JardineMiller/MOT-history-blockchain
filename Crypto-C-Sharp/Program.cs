using System;

namespace CryptoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockchain = new Blockchain();

            blockchain.CreateTransaction(new Transaction("address1", "address2", 100));
            blockchain.CreateTransaction(new Transaction("address2", "address1", 50));
            blockchain.CreateTransaction(new Transaction("address2", "address1", 500));


            Console.WriteLine("Starting the miner...");
            blockchain.MinePendingTransactions("Jardine-Address");

            Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));


            Console.WriteLine("Starting the miner...");
            blockchain.MinePendingTransactions("Jardine-Address");

            Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));
        }
    }
}
