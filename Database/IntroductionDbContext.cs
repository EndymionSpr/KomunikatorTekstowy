using System;
using System.Collections.Generic;
using KomunikatorTekstowy.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KomunikatorTekstowy.Database
{
    public class IntroductionDbContext : DbContext
    {
        public IntroductionDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Nickname = "User1"
                ,
                Password = "qweqwe"
            },
            new User()
            {
                Id = 2,
                Nickname = "User2"
                ,
                Password = "qweqwe"
            },
            new User()
            {
                Id = 3,
                Nickname = "User3"
                ,
                Password = "qweqwe"
            },
            new User()
            {
                Id = 4,
                Nickname = "User4"
              ,
                Password = "qweqwe"
            });
        }
        public DbSet<User> Users { get; set; }
    }
}