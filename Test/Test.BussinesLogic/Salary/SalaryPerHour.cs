using Test.BussinesLogic.Interfaces;
using Test.Transversal.Model;

namespace Test.BussinesLogic.Salary
{
    public class SalaryPerHour : ISalary
    {
        private Employee employe;
        public SalaryPerHour(Employee employe)
        {
            this.employe = employe;
        }
        public decimal TotalSalary()
        {
            return (120 * this.employe.hourlySalary * 12);
        }
    }
}
