using AutoMapper;
using KomunikatorTekstowy.DTO;
using KomunikatorTekstowy.Models;
using System;


namespace KomunikatorTekstowy.Mapper
{
    public class AutoMap: Profile 
    {
        public AutoMap()
        {

            CreateMap<User, UsersDTO>()
                .ForMember(d => d.Id, source => source.MapFrom(s => s.Id))
                .ForMember(d => d.Nickname, source => source.MapFrom(s => s.Nickname))
                .ForMember(d => d.Password, source => source.MapFrom(s => s.Password));

            CreateMap<UsersDTO, User>()
                .ForMember(d => d.Id, source => source.MapFrom(s => s.Id))
                .ForMember(d => d.Nickname, source => source.MapFrom(s => s.Nickname))
                .ForMember(d => d.Password, source => source.MapFrom(s => s.Password));

<<<<<<< HEAD
            CreateMap<Chat, ChatsDTO>()
=======
            CreateMap<Chats, ChatsDTO>()
>>>>>>> Adrian
                .ForMember(d => d.Id, source => source.MapFrom(s => s.Id))
                .ForMember(d => d.User_id, source => source.MapFrom(s => s.User_id))
                .ForMember(d => d.Path, source => source.MapFrom(s => s.Path));

<<<<<<< HEAD
            CreateMap<ChatsDTO, Chat>()
=======
            CreateMap<ChatsDTO, Chats>()
>>>>>>> Adrian
                .ForMember(d => d.Id, source => source.MapFrom(s => s.Id))
                .ForMember(d => d.User_id, source => source.MapFrom(s => s.User_id))
                .ForMember(d => d.Path, source => source.MapFrom(s => s.Path));

        }
    }
}
