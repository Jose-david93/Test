using Test.Transversal.Model;
using Test.AccesData.Employees;
using System.Collections.Generic;
using System.Linq;
using Test.BussinesLogic.Factory;
using Test.BussinesLogic.Interfaces;

namespace Test.BussinesLogic.EmployeeBL
{
    public class EmployeeBL
    {
        public ResultData<List<Employee>> GetEmployees()
        {
            SalaryFactory factory = new SalaryFactory();
            ResultData<List<Employee>> Result = new ResultData<List<Employee>>();
            List<Employee> resultListEmployee = new Employees().GetEmployees();
            foreach (Employee employee in resultListEmployee)
            {
                ISalary salary = factory.Create(employee);
                employee.totalSalary = salary.TotalSalary();
            }

            if (resultListEmployee == null)
            {
                Result.Result = false;
                Result.Message = "Fail service";
            }
            else
            {
                Result.Result = true;
                Result.Data = resultListEmployee;
            }
            return Result;
        }

        public ResultData<List<Employee>> GetEmployees(Employee employee)
        {
            SalaryFactory factory = new SalaryFactory();
            ResultData<List<Employee>> Result = new ResultData<List<Employee>>();
            List<Employee> resultListEmployee = new Employees().GetEmployees().Where(item => item.id == employee.id).ToList();
            foreach (Employee emp in resultListEmployee)
            {
                ISalary salary = factory.Create(emp);
                emp.totalSalary = salary.TotalSalary();
            }
           
            if (resultListEmployee == null)
            {
                Result.Result = false;
                Result.Message = "Fail service";
            }
            else
            {
                Result.Result = true;
                Result.Data = resultListEmployee;
            }
            return Result;
        }
    }
}
