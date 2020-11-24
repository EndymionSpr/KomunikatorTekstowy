using KomunikatorTekstowy.Database;
using KomunikatorTekstowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Repository
{
    public class ChatsRepository : IChatsRepository
    {
        private IntroductionDbContext context;

        public ChatsRepository(IntroductionDbContext context)
        {
            this.context = context;
        }

        public List<Chat> GetChats()
        {
            return context.Chats.ToList();
        }

        public Chat GetById(int id)
        {
            return context.Chats.Find(id);
        }

        public void Insert(Chat chat)
        {
            context.Chats.Add(chat);
        }

        public void Delete(int id)
        {
            Chat chat = context.Chats.Find(id);
            context.Chats.Remove(chat);
        }

        public void Update(Chat chat)
        {
            context.Entry(chat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
