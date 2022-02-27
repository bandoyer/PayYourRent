using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace PayYourRent.Infrastructure.Data;

public class PayYourRentContext : DbContext
{
    public PayYourRentContext(DbContextOptions<PayYourRentContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}