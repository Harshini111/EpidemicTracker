using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Website.Models;
using Employee.Website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController(JsonFileEmployeeService employeeService)
        {
            this.EmployeeService = employeeService;
        }

        public JsonFileEmployeeService EmployeeService { get; }

        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            return EmployeeService.GetEmployee(); //Get Employees from EmployeeService which is JsonFileEmployeeService 
        }

        [Route("EmployeeInfo")]
        [HttpGet]
        public Employees Get([FromQuery] int Id)
        {
            return EmployeeService.GetEmployeeById(Id);
        }

        [Route("Delete")]
        [HttpGet]
        public ActionResult Delete([FromQuery]int Id)
        {
            EmployeeService.DeleteEmployeeById(Id);
            return Ok();
        }

        [Route("Add")]
        [HttpPost]
        public ActionResult Post([FromBody] Employees employee)
        {
            EmployeeService.AddEmployee(employee);
            return Ok();
        }
    }
}