using Microsoft.EntityFrameworkCore;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Data;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Entities;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public List<Employee> GetEmployees()
        {
            return AdaptEntitiesToEmployeeModel(_context.Entities.ToList<EmployeeEntity>());
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return AdaptEntitiesToEmployeeModel(await _context.Entities.ToListAsync<EmployeeEntity>());
        }

        private static List<Employee> AdaptEntitiesToEmployeeModel(List<EmployeeEntity> employeeEntities)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee? employee;

            foreach (EmployeeEntity employeeEntity in employeeEntities)
            {
                employee = new Employee()
                {
                    FirstName = employeeEntity.FirstName,
                    LastName = employeeEntity.LastName,
                    MiddleName = employeeEntity.MiddleName,
                    Designation = employeeEntity.Designation,
                };

                employeeList.Add(employee);
            }

            return employeeList;
        }
    }
}
