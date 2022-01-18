using Microsoft.EntityFrameworkCore;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Data
{
    public interface IDataContext
    {
        DbSet<EmployeeEntity> Entities { get; set; }
        Task<int> SaveChanges();
    }
}
