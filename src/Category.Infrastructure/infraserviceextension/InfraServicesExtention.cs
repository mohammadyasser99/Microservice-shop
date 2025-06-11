using Category.Infrastructure.interfaces.IRepositpories;
using Category.Infrastructure.Repositories;
using Category.Infrastructure.UnitOfWorkDb;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.infraserviceextension
{
    public static class InfraServicesExtention 
    {
        public static void AddInfraServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
        }

        }
}
