using System;
using Application;
using FluentValidation;

namespace Web.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>();
            return services;
        }
    }
}

