using LSP.LiskovSubstitutionPrinciple.Good.Interfaces;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.AccountTypes
{
    public abstract class PaidAccountAccess : IArticle, ICourse
    {
        public abstract List<string> GetArticlesAccessDetails();

        public abstract List<string> GetCoursesAccessDetails();
    }
}
