using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class AppDbContext : DbContext
{
    public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options)
    {
    }

    public DbSet<Algorithm> Algorithms { get; set; }

}
