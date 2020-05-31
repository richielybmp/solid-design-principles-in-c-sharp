using LSP.LiskovSubstitutionPrinciple.Good.Interfaces;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good
{
    public class FreeAccount : IArticle
    {
        public List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }
    }
}
