using System.Data.Entity;
using Template.EntityFramework.Mapping;

namespace Template.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("AppEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationUserMapping())
                ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
