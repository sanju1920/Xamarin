using Microsoft.EntityFrameworkCore;
using SqliteApp.Standard.EntityModels;

namespace SqliteApp.Standard
{
    public class AirlineContext: DbContext
    {
        private readonly string _databasePath;

        public DbSet<Users> Users { set; get; }
        public DbSet<Meals> Meals { set; get; }

        public AirlineContext(string databasePath)
        {
            _databasePath = databasePath;
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Filename={_databasePath}");
        }     
    }
}
