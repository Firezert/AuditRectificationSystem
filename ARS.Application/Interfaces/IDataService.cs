using ARS.Domain.Case;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Application.Interfaces
{
    public interface IDataService 
    {

        public DbSet <AuditCase> AuditCases { get; set; }
        //public DbSet<Branch> Branches { get; set; }
    }
}
