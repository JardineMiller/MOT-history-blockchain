using System;
using System.Collections.Generic;
namespace CryptoCSharp
{
    public class Block
    {
        public readonly DateTime TimeStamp;
        public readonly List<Transaction> Transactions;
        public readonly String PreviousHash;

        public Block(DateTime timeStamp, List<Transaction> transactions, string previousHash)
        {
            TimeStamp = timeStamp;
            Transactions = transactions;
            PreviousHash = previousHash;
        }
    }
}
