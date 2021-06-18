using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Database
{
    [Route("api/Database")]
    public class DatabaseController : ApiController
    {
        private readonly Context _context;

        public DatabaseController(Context context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Employee> GetEmployeeDetails()
        {
            return _context.Employees.ToList();
        }






        
        
    }
}
