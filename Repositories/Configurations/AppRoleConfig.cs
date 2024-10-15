
using Entities.Models.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                 new AppRole(){Id = 1, Name = "User", NormalizedName="USER"},
                new AppRole(){Id = 2, Name = "Editor", NormalizedName="EDITOR"},
                new AppRole(){Id = 3, Name = "Admin", NormalizedName="ADMIN"}
            );
        }
    }
}