using System;
using System.Collections.Generic;
namespace CryptoCSharp
{
    public class Blockchain
    {
        public List<Block> Chain;
        public List<Transaction> PendingTransactions;
        public readonly int Difficulty;
        public readonly int MiningReward;


        public Blockchain()
        {
            Chain = new List<Block>();
            Difficulty = 2;
            PendingTransactions = new List<Transaction>();
            MiningReward = 100;
            createGenesisBlock();
        }

        private void createGenesisBlock() {
            Block block = new Block(DateTime.Parse("2000-01-01"), new List<Transaction>(), "0");
            Chain.Add(block);
        }
    }
}
