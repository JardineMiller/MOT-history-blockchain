using System;
namespace CryptoCSharp
{
    public class Notes
    {
        public readonly string ReasonsForFailure;
        public readonly string AdvisoryNotes;

        public Notes(string advisoryNotes = "", string reasonsForFailure = "")
        {
            ReasonsForFailure = reasonsForFailure;
            AdvisoryNotes = advisoryNotes;
        }
    }
}
