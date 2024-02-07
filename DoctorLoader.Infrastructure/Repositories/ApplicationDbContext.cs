using DoctorLoader.Domain;
using DoctorLoader.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DoctorLoader.Infrastructure.Repositories
{
    internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentRequest> DocumentRequests { get; set; }
        public DbSet<DocumentResponse> DocumentResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentConfiguration).Assembly);
        }
    }
}
