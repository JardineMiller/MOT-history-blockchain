using System;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace CryptoCSharp
{
    public class Block
    {
        public readonly DateTime TimeStamp;
        public readonly List<Transaction> Transactions;
        public readonly string PreviousHash;
        public string Hash;
        public int Nonce;


        public Block(DateTime timeStamp, List<Transaction> transactions, string previousHash)
        {
            TimeStamp = timeStamp;
            Transactions = transactions;
            PreviousHash = previousHash;
            Hash = CalculateHash();
            Nonce = 0;
        }

        public string CalculateHash() {
            return SHA.GenerateSHA256String(TimeStamp + PreviousHash + Nonce + JsonConvert.SerializeObject(Transactions));
        }

        public void MineBlock(int difficulty) {
            List<string> substring = new List<string>(new string[difficulty + 1]);
            string joined = String.Join("0", substring);

            while(Hash.Substring(0, difficulty) != joined) {
                Nonce++;
                Hash = CalculateHash();
            }

            Console.WriteLine("BLOCK MINED: " + Hash);
        }
    }
}
