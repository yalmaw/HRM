using HRM.API.Models;
using HRM.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;


    }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            try
            {
                var allemployess = await _employeeService.GetEmployees();
                return Ok(allemployess);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
            //return await _context.Employees.ToListAsync();
        }
    }
}