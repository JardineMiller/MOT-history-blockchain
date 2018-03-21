using System;
using System.Collections.Generic;

namespace CryptoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockchain = new Blockchain();

            var car = new Vehicle("L101VLY", 110439);
            var dates = new Dates(DateTime.Parse("2018-01-19"), DateTime.Parse("2019-01-19"));
            var notes = new Notes(new List<string>{ "Oil Leak" });
            var mot = new MOT(true, 367580191855, dates, car, notes);

            blockchain.CreateTransaction(new Transaction("L101VLY", mot));



            //blockchain.CreateTransaction(new Transaction(null, "address1", 100));
            //blockchain.CreateTransaction(new Transaction("address1", "address2", 50));
            //blockchain.CreateTransaction(new Transaction("address2", "address1", 10));


            blockchain.MinePendingTransactions("Jardine-Address");
            var history = blockchain.GetVehicleHistory("L101VLY");

            //Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));

            //blockchain.MinePendingTransactions("Jardine-Address");

            //Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));
            //Console.WriteLine("Balance of address1: " + blockchain.GetAddressBalance("address1"));
            //Console.WriteLine("Balance of address2: " + blockchain.GetAddressBalance("address2"));

            //blockchain.CreateTransaction(new Transaction("Jardine-Address", "address2", 50));
            //blockchain.MinePendingTransactions("Jardine-Address");

            //Console.WriteLine("Balance of Jardine-Address: " + blockchain.GetAddressBalance("Jardine-Address"));
            //Console.WriteLine("Balance of address1: " + blockchain.GetAddressBalance("address1"));
            //Console.WriteLine("Balance of address2: " + blockchain.GetAddressBalance("address2"));
        }
    }
}
