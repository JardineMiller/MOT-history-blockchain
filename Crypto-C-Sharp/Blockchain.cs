using System;
using System.Collections.Generic;
namespace CryptoCSharp
{
    public class Blockchain
    {
        public List<Block> Chain;
        public List<Transaction> PendingTransactions;
        public readonly int Difficulty;
        public readonly float MiningReward;


        public Blockchain()
        {
            Chain = new List<Block>();
            Difficulty = 2;
            PendingTransactions = new List<Transaction>();
            MiningReward = 100;
            CreateGenesisBlock();
        }

        private void CreateGenesisBlock() {
            var block = new Block(DateTime.Parse("2000-01-01"), new List<Transaction>(), "0");
            Chain.Add(block);
        }

        public Block GetLatestBlock() {
            return Chain[Chain.Count - 1];
        }

        public void CreateTransaction(Transaction transaction) {
            PendingTransactions.Add(transaction);
        }

        public void MinePendingTransactions(string miningRewardAddress) {
            Console.WriteLine("Starting the miner...");
            var block = new Block(DateTime.Now, new List<Transaction>(PendingTransactions), GetLatestBlock().Hash);
            block.MineBlock(Difficulty);

            Console.WriteLine("Block mined successfully");
            Chain.Add(block);

            PendingTransactions.Clear();
            PendingTransactions.Add(new Transaction(null, miningRewardAddress, MiningReward));
        }

        public bool IsChainValid() {
            for (var i = 1; i < Chain.Count; i++) {
                var currentBlock = Chain[i];
                var prevBlock = Chain[i - 1];
                if (currentBlock.Hash != currentBlock.CalculateHash()) return false;
                if (currentBlock.PreviousHash != prevBlock.Hash) return false;
            }
            return true;
        }

        public float GetAddressBalance(string address) {
            float balance = 0.0F;

            foreach(Block block in Chain) {
                foreach(Transaction trans in block.Transactions) {
                    if (trans.FromAddress == address) balance -= trans.Amount;
                    if (trans.ToAddress == address) balance += trans.Amount;
                }
            }

            return balance;
        }
    }
}
