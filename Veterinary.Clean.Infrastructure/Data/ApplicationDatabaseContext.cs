using Microsoft.EntityFrameworkCore;

namespace Veterinary.Clean.Infrastructure.Data
{
    public class ApplicationDatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            const string connectionString = "";
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)));
        }
    }
}
