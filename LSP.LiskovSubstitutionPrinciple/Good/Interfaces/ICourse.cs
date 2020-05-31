using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good.Interfaces
{
    interface ICourse
    {
        List<string> GetCoursesAccessDetails();
    }
}
