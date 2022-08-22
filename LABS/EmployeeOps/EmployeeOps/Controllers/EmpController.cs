using EmployeeOps.Models;
using EmployeeOps.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpRepo _empDb;
        public EmpController(IEmpRepo pEmp)
        {
            _empDb = pEmp;
        }
        [HttpGet("/employees/list")]
        public IActionResult ListEmp()
        {
            return Ok(_empDb.ListEmp());
        }
        [HttpPost("/employee/hire")]
        public IActionResult HireEmp([FromBody] Employee pEmp)
        {
            try
            {
                int pId = _empDb.HireEmp(pEmp);
                return Created($"Generated Employee ID {pId} for the new hire!", pEmp);
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut("/employee/update_designation/{pId}")]
        public IActionResult UpdateDesignation([FromRoute] int pId, [FromBody] string updatedDesignation)
        {
            try
            {
                _empDb.UpdateDesignation(pId, updatedDesignation);
                return Accepted($"Designation update was successful for Employee ID {pId}!");
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }
        }
        [HttpDelete("/employee/resign/{pId}")]
        public IActionResult Resign([FromRoute] int pId)
        {
            _empDb.Resign(pId);
            return Accepted($"Employee with ID {pId} has resigned.");
        }
        [HttpGet("/employee/find/{pId:int:min(100000):max(999999)}")]
        public IActionResult FindEmployee([FromRoute] int pId)
        {
            Employee foundEmployee = _empDb.GetEmployee(pId);
            return Ok(foundEmployee);
        }
    }
}
