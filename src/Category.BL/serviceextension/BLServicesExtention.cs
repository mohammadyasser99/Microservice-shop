using Category.BL.services;
using Category.Infrastructure.interfaces.IServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.BL.serviceextension
{
    public static class BLServicesExtention
    {
        public static void AddBLServices(this IServiceCollection services)
        {

            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
