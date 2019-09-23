using System.Collections.Generic;
using Test.Transversal.Helper;
using Test.Transversal.Model;

namespace Test.AccesData.Employees
{
    public class Employees
    {
        private static string UrlApiEmployees = "http://masglobaltestapi.azurewebsites.net/api/Employees";
        public List<Employee> GetEmployees()
        {
            return Api.CallApi<List<Employee>>(UrlApiEmployees);
        }
    }
}
