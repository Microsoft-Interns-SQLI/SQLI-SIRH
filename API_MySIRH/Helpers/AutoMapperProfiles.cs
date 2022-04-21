using API_MySIRH.DTOs;
using API_MySIRH.DTOs.Auth;
using API_MySIRH.Entities;
using API_MySIRH.Entities.Auth;
using AutoMapper;

namespace API_MySIRH.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ToDoItem, ToDoItemDTO>().ReverseMap();
            CreateMap<ToDoListDTO, ToDoList>().ForMember(s => s.ToDoItemList, c => c.MapFrom(m => m.ToDoItemList)).ReverseMap();
            CreateMap<Memo, MemoDTO>().ReverseMap();
            CreateMap<Niveau, NiveauDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<Site, SiteDTO>().ReverseMap();
            CreateMap<Collaborateur, CollaborateurDTO>().ReverseMap();
            CreateMap<SkillCenter, SkillCenterDTO>().ReverseMap();
            CreateMap<TypeContrat, TypeContratDTO>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Dashboard, DashboardDto>().ReverseMap();
            CreateMap<ModeRecrutement, ModeRecrutementDTO>().ReverseMap();
            CreateMap<Document, FileDTO>().ReverseMap();

            CreateMap<EntityBase, DtoBase>().ReverseMap();
        }
    }
}
