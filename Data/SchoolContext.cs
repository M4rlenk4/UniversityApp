namespace University.Data;

using University.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class SchoolContext : IdentityDbContext<ApplicationUser>
{

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {

    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Student>().ToTable("Student");
    }

}