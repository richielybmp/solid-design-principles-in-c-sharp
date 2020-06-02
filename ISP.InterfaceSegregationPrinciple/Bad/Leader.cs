using ISP.InterfaceSegregationPrinciple.Bad.Interface;

namespace ISP.InterfaceSegregationPrinciple.Bad
{
    public class Leader : ILead
    {
        public void CreateTask()
        {
            // ... create task
        }

        public void ReviewTask()
        {
            // ... review task
        }

        public void WorkOnTask()
        {
            // .. work on task
        }
    }
}
