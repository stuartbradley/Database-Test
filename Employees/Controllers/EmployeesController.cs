using Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly Context _dbContext;

        public EmployeesController(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult GetAllEmployees()
        {
            return Ok("Hello World");
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public IActionResult CreateNewEmployee(Employee employee)
        {
            return Ok(4);
        }

        [HttpPut("Id")]
        public IActionResult UpdateEmployeeDetails(Employee employee)
        {
            return Ok();
        }

    }
}
