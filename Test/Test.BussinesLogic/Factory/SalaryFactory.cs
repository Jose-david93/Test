using Test.BussinesLogic.Interfaces;
using Test.BussinesLogic.Salary;
using Test.Transversal.Model;

namespace Test.BussinesLogic.Factory
{
    public class SalaryFactory
    {
        public ISalary Create(Employee employee)
        {
            if (employee.contractTypeName.Equals("HourlySalaryEmployee"))
                return new SalaryPerHour(employee);
            else if (employee.contractTypeName.Equals("MonthlySalaryEmployee"))
                return new SalaryperMonth(employee);
            else
                return new SalaryPerDefault();
        }
    }
}
