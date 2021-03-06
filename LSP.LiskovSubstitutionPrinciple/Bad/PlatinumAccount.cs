﻿using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Bad
{
    public class PlatinumAccount : AccountAccess
    {
        public override List<string> GetArticlesAccessDetails()
        {
            return new List<string>() { "Article One", "Article Two" };
        }

        public override List<string> GetCoursesAccessDetails()
        {
            return new List<string>() { "Course A", "Course B" };
        }

        public override List<string> GetMentorAccessDetails()
        {
            return new List<string>() { "Alice", "Bob" };
        }
    }
}
