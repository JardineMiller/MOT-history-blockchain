using System;
using System.Collections.Generic;

namespace CryptoCSharp

{
    public class Notes
    {
        public readonly List<string> ReasonsForFailure;
        public readonly List<string> AdvisoryNotes;

        public Notes(List<string> advisoryNotes = default(List<string>), List<string> reasonsForFailure = default(List<string>))
        {
            ReasonsForFailure = reasonsForFailure;
            AdvisoryNotes = advisoryNotes;
        }
    }
}
