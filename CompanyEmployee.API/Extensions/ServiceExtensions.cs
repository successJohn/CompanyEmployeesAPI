using CompanyEmployee.Entities;
using CompanyEmployee.Repository.Implementation;
using CompanyEmployee.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployee.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>

                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());


            });


        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b => 
            b.MigrationsAssembly("CompanyEmployee.API")));

        public static void ConfigureRepositories(this IServiceCollection services) =>
                services.AddScoped<IUnitOfWork, UnitOfWork>();

    }
}
