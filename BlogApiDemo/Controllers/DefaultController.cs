using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var ctx = new Context();
            var values = ctx.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var ctx = new Context();
            ctx.Employees.Add(employee);
            ctx.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGetId(int id)
        {
            using var ctx = new Context();
            var employee = ctx.Employees.Find(id);
            if (employee is null)
                return NotFound();
            else
                return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var ctx = new Context();
            var employee = ctx.Employees.Find(id);
            if (employee is null)
                return NotFound();
            else
            {
                ctx.Remove(employee);
                ctx.SaveChanges();
                return Ok(employee);
            }
        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var ctx = new Context();
            var updEmployee = ctx.Find<Employee>(employee.ID);
            if (updEmployee is null) 
                return NotFound();
            else
            {
                updEmployee.Name = employee.Name;
                ctx.Update(updEmployee);
                ctx.SaveChanges();
                return Ok();
            }
        }
    }
}
