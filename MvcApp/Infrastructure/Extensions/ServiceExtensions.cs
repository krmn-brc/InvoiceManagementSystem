
using Repositories.Concrete;
using Repositories.Contracts;
using Services.Concrete;
using Services.Contracts;

namespace MvcApp.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IBlockRepository, BlockRepository>();
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTypeRepository, InvoiceTypeRepository>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IBlockService, BlockManager>();
            services.AddScoped<IHouseService, HouseManager>();
            services.AddScoped<IInvoiceService, InvoiceManager>();
            services.AddScoped<IInvoiceTypeService, InvoiceTypeManager>();
        }
    }
}