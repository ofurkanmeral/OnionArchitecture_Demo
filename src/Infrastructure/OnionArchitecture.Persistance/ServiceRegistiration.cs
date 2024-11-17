using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Persistance.Repositories;

namespace OnionArchitecture.Persistance
{
    public static class ServiceRegistiration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer("server=...;database=...;user=...;password=..."));
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
