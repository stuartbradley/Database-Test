using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeedBy { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
