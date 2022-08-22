using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeOps.Models;

namespace EmployeeOps.Data
{
    public class EmployeeOpsContext : DbContext
    {
        public EmployeeOpsContext (DbContextOptions<EmployeeOpsContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeOps.Models.Employee> Employee { get; set; } = default!;
    }
}
