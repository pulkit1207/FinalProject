using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
      
        private readonly ILogger<EmployeeController> _logger;

        private readonly List<Employee> emp = new List<Employee>()
        {
            new Employee { EmpID = 1, FirstName = "Chris", LastName = "Dyck", Department = "Big Data", Salary = 100000 },
            new Employee { EmpID = 2, FirstName = "Jonathan", LastName= "Wiersma", Department = "Statistics", Salary= 90000 },
            new Employee { EmpID = 3, FirstName = "Shannon", LastName= "Mulligan", Department = "Data Manipulation Techniques", Salary = 85000 },
            new Employee { EmpID = 4, FirstName = "Nital", LastName = "Shah", Department = "IES", Salary = 85000 },
            new Employee { EmpID = 5, FirstName = "Saber", LastName = "Amini", Department = "Data System Architecture", Salary = 80000 },
            new Employee { EmpID = 6, FirstName = "Pedram", LastName = "Habibi", Department = "Data Programming", Salary = 75000 },
        };
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp;
         
        }

        [HttpGet("{id:int}")]
        public Employee GetOne(int id)
        {
            return emp.SingleOrDefault(x => x.EmpID == id );
        }
    }

}
