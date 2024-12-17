using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARS.Domain;
using ARS.Domain.Branch;
using ARS.Domain.Case;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ARS.Persistance
{
    public class ARSDbContext:DbContext
    {
       public ARSDbContext(DbContextOptions<ARSDbContext> options):base(options) 
        {
        }

        public DbSet<AuditCase> AuditCases { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
