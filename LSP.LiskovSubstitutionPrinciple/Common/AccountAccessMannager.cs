using LSP.LiskovSubstitutionPrinciple.Bad;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Common
{
    class AccountAccessMannager
    {
        public AccountAccessMannager()
        {

        }

        public void GetMentorFromAccounts(List<AccountAccess> accounts)
        {
            foreach (var account in accounts)
            {
                account.GetMentorAccessDetails();
            }
        }
    }
}