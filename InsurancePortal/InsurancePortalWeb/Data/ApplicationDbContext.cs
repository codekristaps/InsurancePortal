using InsurancePortalWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace InsurancePortalWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Insurance> Insurances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });

            // Seeding data
            modelBuilder.Entity<Insurance>().HasData(
                new Insurance
                {
                    Id = new Guid("d7997d4d-4d56-4c6a-a684-41c6c2329ef1"),
                    Name = "Health Insurance Plan A",
                    Description = "Comprehensive health insurance for individuals.",
                    Price = 299.99m,
                    ImageUrl = "https://example.com/images/health-insurance-a.jpg"
                },
                new Insurance
                {
                    Id = new Guid("b849b20c-2d79-48c2-82a7-631d21357e67"),
                    Name = "Car Insurance Plan B",
                    Description = "Full coverage car insurance with roadside assistance.",
                    Price = 499.99m,
                    ImageUrl = "https://example.com/images/car-insurance-b.jpg"
                },
                new Insurance
                {
                    Id = new Guid("6fa1b91f-f84d-4c0c-8815-d6c62251cc3b"),
                    Name = "Home Insurance Plan C",
                    Description = "Protection for your home and belongings.",
                    Price = 399.99m,
                    ImageUrl = "https://example.com/images/home-insurance-c.jpg"
                }
            );
        }
    }
}
