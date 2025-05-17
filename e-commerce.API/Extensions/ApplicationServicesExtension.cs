using e_commerce.API.Helpers;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Core.ServicesInterfaces;
using e_commerce.Repository.Repositories;
using e_commerce.Service;

namespace e_commerce.API.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IBrandService , BrandService>();
            services.AddScoped<ICategoriesService , CategoriesService>();

            return services;
        }
    }
}
