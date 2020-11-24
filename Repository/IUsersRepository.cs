using KomunikatorTekstowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Repository
{
     interface IUsersRepository
    {
        List<User> GetUsers();

        User GetById(int id);

        void Insert(User user);

        void Delete(int id);

        void Update(User user);

        void Save();
    }
}
