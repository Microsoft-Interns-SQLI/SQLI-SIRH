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
            CreateMap<ToDoListDTO, ToDoList>().ForMember(s => s.ToDoItemList, c => c.MapFrom(m => m.ToDoItemList)).ReverseMap();
            CreateMap<Diplome, DiplomeDTO>().ReverseMap();
            CreateMap<Memo, MemoDTO>().ReverseMap();
            CreateMap<Niveau, NiveauDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<Site, SiteDTO>().ReverseMap();
            CreateMap<SkillCenter, SkillCenterDTO>().ReverseMap();
            CreateMap<TypeContrat, TypeContratDTO>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Dashboard, DashboardDto>().ReverseMap();
            CreateMap<ModeRecrutement, ModeRecrutementDTO>().ReverseMap();
            CreateMap<Document, FileDTO>().ReverseMap();

            CreateMap<Demission, DemissionDTO>().ReverseMap();

            CreateMap<CollaborateurTypeContratDTO, CollaborateurTypeContrat>().ReverseMap();
            CreateMap<CollaborateurDTO, Collaborateur>().ReverseMap();

            CreateMap<Certification, CertificationDTO>().ReverseMap();
            CreateMap<CollaborateurCertification, CollaborateurCertificationDTO>().ReverseMap();

            CreateMap<Formation, FormationDTO>().ReverseMap();
            CreateMap<CollaborateurFormation, CollaborateurFormationDTO>().ReverseMap();

            CreateMap<EntityBase, DtoBase>().ReverseMap();
        }
    }
}
