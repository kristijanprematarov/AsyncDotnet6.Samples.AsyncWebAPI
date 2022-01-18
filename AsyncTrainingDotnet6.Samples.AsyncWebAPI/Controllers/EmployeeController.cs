using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Models;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Services;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet]
        [Route("GetEmployeesAsync")]
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            try
            {
                return await _employeeService.GetEmployeesAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
    }
}
