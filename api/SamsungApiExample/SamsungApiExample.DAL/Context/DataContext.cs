using Microsoft.EntityFrameworkCore;
using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.DAL.Context;
public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasOne(p => p.Address)
            .WithOne(a => a.User);

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "Petru", LastName = "Virlan", Email="petru.virlan@samsung.com"},  
            new User { Id = 2, FirstName = "John", LastName = "Doe", Email="john.doe@samsung.com"},   
            new User { Id = 3, FirstName = "Doe", LastName = "John", Email="doe.john@samsung.com"} 
        );

        modelBuilder.Entity<Address>().HasData(
            new Address { Id = 1, UserId = 1, City = "Bucharest", Country = "Romania", Street = "Str Martisor", ZipCode = "000000" },
            new Address { Id = 2, UserId = 2, City = "London", Country = "United Kingdom", Street = "Chelsea Bridge Rd", ZipCode = "111111" }
        );

    }
}
