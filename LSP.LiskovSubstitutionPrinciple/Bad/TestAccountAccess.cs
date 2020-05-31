using LSP.LiskovSubstitutionPrinciple.Common;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Bad
{
    public static class TestAccountAccess
    {
        static void GetAccountAccess()
        {
            AccountAccessMannager accountAccess = new AccountAccessMannager();

            List<AccountAccess> accounts = new List<AccountAccess>();
            accounts.Add(new FreeAccount());
            accounts.Add(new GoldAccount());
            accounts.Add(new PlatinumAccount());

            accountAccess.GetMentorFromAccounts(accounts);
        }
    }
}
