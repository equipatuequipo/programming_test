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
            entity.Property(e => e.FirstName).HasColumnType("NVARCHAR(40)");
            entity.Property(e => e.LastName).HasColumnType("NVARCHAR(20)");
            entity.Property(e => e.Email).HasColumnType("NVARCHAR(60)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
