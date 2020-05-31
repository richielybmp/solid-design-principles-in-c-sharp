using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Bad
{
    public abstract class AccountAccess
    {
        public abstract List<string> GetArticlesAccessDetails();

        public abstract List<string> GetCoursesAccessDetails();

        public abstract List<string> GetMentorAccessDetails();
    }
}
