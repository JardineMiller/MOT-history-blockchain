using System;
namespace CryptoCSharp
{
    public class Dates
    {
        public readonly DateTime Tested;
        public readonly DateTime Expires;

        public Dates(DateTime tested, DateTime expires)
        {
            Tested = tested;
            Expires = expires;
        }
    }
}
