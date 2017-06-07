using System.Data.Entity.ModelConfiguration;
using Template.Entities;

namespace Template.EntityFramework.Mapping
{
    public class ApplicationUserMapping : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMapping()
        {
            ToTable("ApplicationUser", "dbo");
            HasKey(user => user.UserId);
            Property(user => user.UserId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
