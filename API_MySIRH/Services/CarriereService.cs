using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CarriereService : ICarriereService
    {
        private readonly ICarriereRepository _carriereRepository;
        private readonly IMapper _mapper;

        public CarriereService(ICarriereRepository carriereRepository, IMapper mapper)
        {
            this._carriereRepository = carriereRepository;
            this._mapper = mapper;
        }

        public async Task<CarriereDTO?> Add(CarriereDTO carriereDTO)
        {
            return this._mapper.Map<CarriereDTO>(await this._carriereRepository.Add(this._mapper.Map<Carriere>(carriereDTO)));
        }

        public async Task Delete(CarriereDTO carriereDTO)
        {
            await this._carriereRepository.Delete(this._mapper.Map<Carriere>(carriereDTO));
        }

        public async Task<bool> Exists(int idCarriere)
        {
            return await this._carriereRepository.Exists(idCarriere);
        }

        public async Task<CarriereDTO?> FindById(int id)
        {
            return this._mapper.Map<CarriereDTO>(await this._carriereRepository.FindById(id));
        }

        public async Task<List<CarriereDTO>?> GetAll()
        {
            return this._mapper.Map<List<CarriereDTO>>(await this._carriereRepository.GetAll());
        }

        public async Task<List<CarriereDTO>?> GetAllByCollab(int idCollaborateur)
        {
            return this._mapper.Map<List<CarriereDTO>>(await this._carriereRepository.GetAllByCollab(idCollaborateur));
        }

        public async Task Update(CarriereDTO carriereDTO)
        {
            await this._carriereRepository.Update(this._mapper.Map<Carriere>(carriereDTO));
        }
    }
}