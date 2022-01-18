using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Task<List<Employee>> GetEmployeesAsync();
    }
}
