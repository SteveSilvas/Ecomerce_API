using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class AddressStateService : IAddressStateService
    {
        private readonly IAddressStateRepository _iAdressStateRepository;
        private readonly IMapper _mapper;
        public AddressStateService(IAddressStateRepository iAdressStateRepository, IMapper mapper)
        {
            _iAdressStateRepository = iAdressStateRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<AddressState>> GetAll()
        {
            IEnumerable<AddressState> adresses = _iAdressStateRepository.GetAll();
            if (adresses != null)
            {
                return new ResultDTO<IEnumerable<AddressState>>(0, "Sucesso.", adresses);
            }
            else
            {
                return new ResultDTO<IEnumerable<AddressState>>(1, "No employees found.", null);
            }
        }

        public ResultDTO<AddressState> GetById(int addressStateId)
        {
            AddressState addressState = _iAdressStateRepository.GetById(addressStateId);
            if (addressState != null)
            {
                return new ResultDTO<AddressState>(0, "Sucesso.", addressState);
            }
            else
            {
                return new ResultDTO<AddressState>(1, "Departamento não encontrado.", null);
            }
        }


        public ResponseDTO Insert(AddressState addressState)
        {
            try
            {
                _iAdressStateRepository.Insert(addressState);
                return new ResponseDTO(0, "Cidade cadastrada com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Cidade.");
            }
        }

        public ResponseDTO Update(AddressState addressState)
        {
            try
            {
                _iAdressStateRepository.Update(addressState);
                return new ResponseDTO(0, "Estadp alterado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Estado.");
            }
        }


        public ResponseDTO Delete(int addressStateId)
        {
            var addressState = _iAdressStateRepository.GetById(addressStateId);
            if (addressState != null)
            {
                _iAdressStateRepository.Delete(addressStateId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Employee not found.");
            }
        }

        public void Save()
        {
            _iAdressStateRepository.Save();
        }
    }
}
