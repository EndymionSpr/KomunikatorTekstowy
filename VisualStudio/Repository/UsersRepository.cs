using KomunikatorTekstowy.Database;
using KomunikatorTekstowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Repository
{
    public class UsersRepository: IUsersRepository
    {
        private IntroductionDbContext context;

        public UsersRepository(IntroductionDbContext context)
        {
            this.context = context;
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public void Insert(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
        }

        public void Update(User user)
        {
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
