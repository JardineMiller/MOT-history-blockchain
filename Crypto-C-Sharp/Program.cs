using System;

namespace CryptoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockchain = new Blockchain();
            Console.WriteLine(blockchain.Chain[0].PreviousHash);
        }
    }
}
