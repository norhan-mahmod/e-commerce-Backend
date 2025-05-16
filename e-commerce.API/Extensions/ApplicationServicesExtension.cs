using e_commerce.API.Helpers;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Repository.Repositories;

namespace e_commerce.API.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MappingProfiles));

            return services;
        }
    }
}
