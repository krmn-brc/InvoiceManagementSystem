
using Entities.Models.Identities;
using Microsoft.EntityFrameworkCore;
using Repositories.Common;
using Repositories.Concrete;
using Repositories.Contracts;
using Services.Concrete;
using Services.Contracts;

namespace MvcApp.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<RepositoryContext>(options => {
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"), b => b.MigrationsAssembly("MvcApp"));
                
             });
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options => 
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<RepositoryContext>();
        }
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IBlockRepository, BlockRepository>();
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTypeRepository, InvoiceTypeRepository>();
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