using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class AddressCityService : IAddressCityService
    {
        private readonly IAddressCityRepository _iAdressCityRepository;
        private readonly IMapper _mapper;
        public AddressCityService(IAddressCityRepository iAdressCityRepository, IMapper mapper)
        {
            _iAdressCityRepository = iAdressCityRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<AddressCity>> GetAll()
        {
            IEnumerable<AddressCity> adresses = _iAdressCityRepository.GetAll();
            if (adresses != null)
            {
                return new ResultDTO<IEnumerable<AddressCity>>(0, "Sucesso.", adresses);
            }
            else
            {
                return new ResultDTO<IEnumerable<AddressCity>>(1, "No employees found.", null);
            }
        }

        public ResultDTO<AddressCity> GetById(int addressCityId)
        {
            AddressCity addressCity = _iAdressCityRepository.GetById(addressCityId);
            if (addressCity != null)
            {
                return new ResultDTO<AddressCity>(0, "Sucesso.", addressCity);
            }
            else
            {
                return new ResultDTO<AddressCity>(1, "Departamento não encontrado.", null);
            }
        }


        public ResponseDTO Insert(AddressCity addressCity)
        {
            try
            {
                _iAdressCityRepository.Insert(addressCity);
                return new ResponseDTO(0, "Cidade cadastrada com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Cidade.");
            }
        }

        public ResponseDTO Update(AddressCity addressCity)
        {
            try
            {
                _iAdressCityRepository.Update(addressCity);
                return new ResponseDTO(0, "Cidade alterada com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Cidade.");
            }
        }


        public ResponseDTO Delete(int addressCityId)
        {
            var addressCity = _iAdressCityRepository.GetById(addressCityId);
            if (addressCity != null)
            {
                _iAdressCityRepository.Delete(addressCityId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Employee not found.");
            }
        }

        public void Save()
        {
            _iAdressCityRepository.Save();
        }
    }
}
