using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend;

public partial class DatabaseContext : DbContext
{
    public static string ConnectionString { get; set; } = @"Data Source=./customers.db";

    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId);
            entity.Property(e => e.Address).HasColumnType("NVARCHAR(70)");
            entity.Property(e => e.City).HasColumnType("NVARCHAR(40)");
            entity.Property(e => e.Company).HasColumnType("NVARCHAR(80)");
            entity.Property(e => e.Country).HasColumnType("NVARCHAR(40)");
            entity.Property(e => e.Email).HasColumnType("NVARCHAR(60)");
            entity.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");
            entity.Property(e => e.FirstName).HasColumnType("NVARCHAR(40)");
            entity.Property(e => e.LastName).HasColumnType("NVARCHAR(20)");
            entity.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");
            entity.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");
            entity.Property(e => e.State).HasColumnType("NVARCHAR(40)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
