using Common.DTOs;
using DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<PrivateUserDetailsDTO>, PrivateUserDetailsService>();
            services.AddSingleton<IContext, MyDbContext>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
