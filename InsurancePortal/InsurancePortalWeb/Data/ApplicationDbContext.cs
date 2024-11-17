using InsurancePortalWeb.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<InsuranceCategory> InsuranceCategories { get; set; }
    public DbSet<Insurance> Insurances { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Set default GUID generation in the database
        modelBuilder.Entity<InsuranceCategory>().Property(e => e.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Insurance>().Property(e => e.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Customer>().Property(e => e.Id).HasDefaultValueSql("NEWID()");

        // Configure precision and scale for decimal properties
        modelBuilder.Entity<Insurance>()
            .Property(e => e.Premium)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Insurance>()
            .Property(e => e.CoverageAmount)
            .HasPrecision(18, 2);
    }

}
