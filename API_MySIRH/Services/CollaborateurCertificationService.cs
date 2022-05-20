﻿using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CollaborateurCertificationService : ICollaborateurCertificationService
    {
        private readonly ICollaborateurCertificationRepository _collaborateurCertificationRepository;
        private readonly IMapper _mapper;

        public CollaborateurCertificationService(ICollaborateurCertificationRepository collaborateurCertificationRepository, IMapper mapper)
        {
            _collaborateurCertificationRepository = collaborateurCertificationRepository;
            _mapper = mapper;
        }

        public async Task Add(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Add(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }

        public Task Delete(CollaborateurCertificationDTO collaborateurCertification)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurCertificationResponse> GetAll(FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurCertificationRepository.GetAll();

            if (filter.status != null && filter.status != 0)
            {
                list = list.Where(cc => cc.Status == filter.status).ToList();
            }

            if (filter.annee != null && filter.annee.ToString().Length >= 4 && filter.annee != 0)
            {
                list = list.Where(cc => cc.DateDebut.Value.Year == filter.annee).ToList();
            }

            var cfDto = _mapper.Map<List<CollaborateurCertificationDTO>>(list);

            return cfDto.GroupBy(x => x.DateDebut.Value.Year).Select(grp => new CollaborateurCertificationResponse { Annee = grp.Key, List = grp.ToList() }).FirstOrDefault();
        }
        public async Task<List<int>> GetAnnees()
        {
            return  await _collaborateurCertificationRepository.GetAnnees();
        }
        public Task<List<CollaborateurCertificationDTO>> GetByCertification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CollaborateurCertificationDTO>> GetByCollaborateur(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurCertificationDTO> GetOne(int collaborateurId, int certificationId)
        {
            return _mapper.Map<CollaborateurCertificationDTO>(await _collaborateurCertificationRepository.GetOne(collaborateurId, certificationId));
        }

        public async Task Update(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Update(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }
    }
}
