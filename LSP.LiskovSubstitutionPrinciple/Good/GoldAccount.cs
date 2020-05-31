using LSP.LiskovSubstitutionPrinciple.AccountTypes;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good
{
    public class GoldAccount : PaidAccountAccess
    {
        public override List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }

        public override List<string> GetCoursesAccessDetails()
        {
            return new List<string>() { "Course A", "Course B" };
        }
    }
}
