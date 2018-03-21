using System;
namespace CryptoCSharp
{
    public class MOT
    {
        public readonly Dates Dates;
        public readonly Vehicle Vehicle;
        public readonly Notes Notes; 
        public readonly double Number;
        public readonly bool Status;


        public MOT(bool status, double number, Dates dates, Vehicle vehicle, Notes notes)
        {
            Status = status;
            Number = number;
            Dates = dates;
            Vehicle = vehicle;
            Notes = notes;
        }
    }
}
