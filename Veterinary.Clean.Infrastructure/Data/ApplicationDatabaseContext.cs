using Microsoft.EntityFrameworkCore;
using Veterinary.Clean.Infrastructure.Entities;

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
        
        public DbSet<Owner> Owners { get; set; }
        
        public DbSet<Pet> Pets { get; set; }
        
        public DbSet<OwnerPet> OwersPets { get; set; }
        
        public DbSet<Consultation> Consultations { get; set; }
    }
}
