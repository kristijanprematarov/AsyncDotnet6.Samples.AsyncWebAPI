using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Designation { get; set; }
        public double Salary { get; set; }
    }
}
