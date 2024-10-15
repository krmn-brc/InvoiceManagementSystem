

using System.Reflection;
using Entities.Models;
using Entities.Models.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Common
{
    public class RepositoryContext: IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Block> Blocks { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}