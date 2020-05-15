using Microsoft.EntityFrameworkCore;
using SqliteApp.Standard.EntityModels;

namespace SqliteApp.Standard
{
    public class AirlineContext: DbContext
    {
        public DbSet<Users> Users { set; get; }
        public DbSet<Meals> Meals { set; get; }

        public AirlineContext()
        {            
           // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Airlines.db");
        }     
    }
}
