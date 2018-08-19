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
            modelBuilder.Entity<Person>().ToTable("Person");

            modelBuilder.Entity<Person>()
                        .HasDiscriminator<int>("Type")
                        .HasValue<Student>(1)
                        .HasValue<Instructor>(2);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
