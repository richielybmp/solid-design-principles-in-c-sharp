using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good.Interfaces
{
    interface IArticle
    {
        List<string> GetArticlesAccessDetails();
    }
}
