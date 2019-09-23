using System;
using Test.BussinesLogic.Interfaces;

namespace Test.BussinesLogic.Salary
{
    public class SalaryPerDefault : ISalary
    {
        public decimal TotalSalary()
        {
            return 0;
        }
    }
}
