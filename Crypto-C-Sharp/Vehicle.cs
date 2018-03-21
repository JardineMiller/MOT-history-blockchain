using System;
namespace CryptoCSharp
{
    public class Vehicle
    {
        public readonly string Registration;
        public readonly double Mileage;

        public Vehicle(string registration, double mileage)
        {
            Registration = registration;
            Mileage = mileage;
        }
    }
}
