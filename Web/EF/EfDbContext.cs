using Microsoft.EntityFrameworkCore;

namespace EfCoreInheritance.EF
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                        .ToTable(nameof(Person))
                        .HasDiscriminator<int>(nameof(Person.Type))
                        .HasValue<Student>(1)
                        .HasValue<Instructor>(2);
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
