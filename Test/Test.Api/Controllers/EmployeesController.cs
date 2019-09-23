using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Transversal.Model;
using Test.BussinesLogic.EmployeeBL;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees
        [Produces("application/json")]
        [EnableCors]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new EmployeeBL().GetEmployees());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/Employees
        [Produces("application/json")]
        [EnableCors]
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                Employee employee = new Employee();
                employee.id = id;
                return Ok(new EmployeeBL().GetEmployees(employee));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
