using LSP.LiskovSubstitutionPrinciple.AccountTypes;
using LSP.LiskovSubstitutionPrinciple.Common;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good
{
    public static class TestAccountAccess
    {
        static void GetAccountAccess()
        {
            AccountAccessMannager accountAccess = new AccountAccessMannager();

            List<PaidAccountAccess> accounts = new List<PaidAccountAccess>();
            accounts.Add(new FreeAccount());
            accounts.Add(new GoldAccount());
            accounts.Add(new PlatinumAccount());

            accountAccess.GetMentorFromAccounts(accounts);
        }
    }
}
