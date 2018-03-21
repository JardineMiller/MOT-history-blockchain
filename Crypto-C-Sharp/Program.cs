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

            var car2 = new Vehicle("L101VLY", 110439);
            var dates2 = new Dates(DateTime.Parse("2018-01-19"));
            var notes2 = new Notes(
                new List<string> { 
                "Coolant level below minimum",
                "Oil Leak",
                "Front brake disc worn, pitted and scored, but not seriously weakened both (3.5.1i)",
                "Front brake fluctuating, but not excessively both (3.7.B.3)"
            }, new List<string> {
                "Nearside Front position lamp(s) not working (1.1.A.3b)",
                "Power steering fluid level below minimum (2.3.1)",
                "Nearside Front Tyre has ply or cords exposed 195/50/15 (4.1.D.1b)"
            });

            var mot2 = new MOT(false, 586456865382, dates2, car2, notes2);

            blockchain.CreateTransaction(new Transaction("L101VLY", mot));
            blockchain.CreateTransaction(new Transaction("L101VLY", mot2));

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
