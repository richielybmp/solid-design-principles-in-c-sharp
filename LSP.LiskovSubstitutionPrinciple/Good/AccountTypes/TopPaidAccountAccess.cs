using LSP.LiskovSubstitutionPrinciple.Good.Interfaces;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.AccountTypes
{
    public abstract class TopPaidAccountAccess : PaidAccountAccess, IMentor
    {
        public abstract List<string> GetMentorAccessDetails();
    }
}
