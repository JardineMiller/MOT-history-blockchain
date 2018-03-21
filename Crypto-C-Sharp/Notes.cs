using System;
using System.Collections.Generic;

namespace CryptoCSharp

{
    public class Notes
    {
        public readonly string ReasonsForFailure;
        public readonly List<string> AdvisoryNotes;

        public Notes(List<string> advisoryNotes = default(List<string>), string reasonsForFailure = "")
        {
            ReasonsForFailure = reasonsForFailure;
            AdvisoryNotes = advisoryNotes;
        }
    }
}
