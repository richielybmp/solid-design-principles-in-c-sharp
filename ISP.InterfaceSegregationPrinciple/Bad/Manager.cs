using ISP.InterfaceSegregationPrinciple.Bad.Interface;
using System;

namespace ISP.InterfaceSegregationPrinciple.Bad
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            // .. create task
        }

        public void ReviewTask()
        {
            // ... review task
        }

        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
