using Test.BussinesLogic.Interfaces;
using Test.Transversal.Model;

namespace Test.BussinesLogic.Salary
{
    public class SalaryperMonth : ISalary
    {
        private Employee employee;
        public SalaryperMonth(Employee employee)
        {
            this.employee = employee;
        }

        public decimal TotalSalary()
        {
            return (this.employee.monthlySalary*12);
        }
    }
}
