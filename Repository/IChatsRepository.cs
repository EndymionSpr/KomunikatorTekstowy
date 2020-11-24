using KomunikatorTekstowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Repository
{
    interface IChatsRepository
    {
        List<Chat> GetChats();

        Chat GetById(int id);

        void Insert(Chat chat);

        void Delete(int id);

        void Update(Chat chat);

        void Save();
    }
}
