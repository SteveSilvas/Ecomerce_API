using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _iAdressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository iAdressRepository, IMapper mapper)
        {
            _iAdressRepository = iAdressRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<Address>> GetAll()
        {
            IEnumerable<Address> adresses = _iAdressRepository.GetAll();
            if (adresses != null)
            {
                return new ResultDTO<IEnumerable<Address>>(0, "Sucesso.", adresses);
            }
            else
            {
                return new ResultDTO<IEnumerable<Address>>(1, "Endereços não encontrados.", null);
            }
        }

        public ResultDTO<Address> GetById(int addressId)
        {
            Address address = _iAdressRepository.GetById(addressId);
            if (address != null)
            {
                return new ResultDTO<Address>(0, "Sucesso.", address);
            }
            else
            {
                return new ResultDTO<Address>(1, "Endereço não encontrado.", null);
            }
        }


        public ResponseDTO Insert(Address address)
        {
            try
            {
                _iAdressRepository.Insert(address);
                return new ResponseDTO(0, "Endereço cadastrado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Endereço.");
            }
        }

        public ResponseDTO Update(Address address)
        {
            try
            {
                _iAdressRepository.Update(address);
                return new ResponseDTO(0, "Endereço alterado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Endereço.");
            }
        }


        public ResponseDTO Delete(int addressId)
        {
            var address = _iAdressRepository.GetById(addressId);
            if (address != null)
            {
                _iAdressRepository.Delete(addressId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Endereço não encontrado.");
            }
        }

        public void Save()
        {
            _iAdressRepository.Save();
        }
    }
}
