using System.Data.Entity;

namespace Mvc5Web.EF
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                        .Map<Student>(m => m.Requires("Type").HasValue(1))
                        .Map<Instructor>(m => m.Requires("Type").HasValue(2));
        }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
