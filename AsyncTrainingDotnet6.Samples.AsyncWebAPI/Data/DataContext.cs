using Microsoft.EntityFrameworkCore;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTrainingDotnet6.Samples.AsyncWebAPI.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeEntity>? Entities { get; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
