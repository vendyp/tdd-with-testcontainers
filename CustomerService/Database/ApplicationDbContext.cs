using CustomerService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = null!;
}