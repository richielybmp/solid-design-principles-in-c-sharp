using ISP.InterfaceSegregationPrinciple.Good.Interface;

namespace ISP.InterfaceSegregationPrinciple.Good
{
    public class Leader : ILead, IProgrammer
    {
        public void CreateTask()
        {
            // ... create task
        }

        public void ReviewTask()
        {
            //... review task
        }

        public void WorkOnTask()
        {
            //... can work on task too
        }
    }
}
