using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using AutoMapper;

namespace API_MySIRH.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ToDoItem, ToDoItemDTO>();
            CreateMap<ToDoItemDTO, ToDoItem>();
            CreateMap<ToDoListDTO, ToDoList>()
                .ForMember(s => s.ToDoItemList, c => c.MapFrom(m => m.ToDoItemList));
            CreateMap<ToDoList, ToDoListDTO>()
                .ForMember(s => s.ToDoItemList, c => c.MapFrom(m => m.ToDoItemList));
            CreateMap<Memo, MemoDTO>();
            CreateMap<MemoDTO, Memo>();
            CreateMap<Niveau, NiveauDTO>().ReverseMap();
        }

    }
}
