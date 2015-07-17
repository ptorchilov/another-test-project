using System.Data.Entity;
using System.Reflection;

namespace FirstWebApp.Context
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<CoreDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}