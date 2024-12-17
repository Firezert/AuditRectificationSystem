using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ARS.Persistance
{
    public static class PersistanceRegistration
    {       
        
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ARSDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("ARSConnection")));

            
            return services;
        }
    }
}
