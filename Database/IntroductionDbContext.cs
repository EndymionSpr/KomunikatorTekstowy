using KomunikatorTekstowy.Models;
using Microsoft.EntityFrameworkCore;


namespace KomunikatorTekstowy.Database
{
    public class IntroductionDbContext : DbContext
    {
        public IntroductionDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users()
            {
                Id = 1,
                Nickname = "Task #1"
                ,
                Password = "qweqwe"
            },
            new Users()
            {
                Id = 2,
                Nickname = "Task #2"
                ,
                Password = "qweqwe"
            },
            new Users()
            {
                Id = 3,
                Nickname = "Task #3"
                ,
                Password = "qweqwe"
            },
            new Users()
            {
                Id = 4,
                Nickname = "Task #4"
              ,
                Password = "qweqwe"
            });
        }
        public DbSet<Users> Users { get; set; }
    }
}