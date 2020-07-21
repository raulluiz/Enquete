using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using Enquete.ApplicationCore.Services;
using Enquete.Infrastructure.Context;
using Enquete.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IPollService, PollService>();
            services.AddScoped<IOptionService, OptionService>();
            services.AddScoped<IPollOptionService, PollOptionService>();

            RegisterRepository(services);
            RegisterContext(services);

            return services;
        }

        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IPollRepository, PollRepository>();
            services.AddScoped<IOptionRepository, OptionRepository>();
            services.AddScoped<IPollOptionRepository, PollOptionRepository>();

            return services;
        }
        public static IServiceCollection RegisterContext(this IServiceCollection services)
        {
            services.AddScoped<EnqueteContext>();
            return services;
        }
    }
}
