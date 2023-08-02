using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _iAddressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository iAddressRepository, IMapper mapper)
        {
            _iAddressRepository = iAddressRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<AddressDTO>> GetAll()
        {
            IEnumerable<Address> addresses = _iAddressRepository.GetAll();
            IEnumerable<AddressDTO> addressesDtos = _mapper.Map<IEnumerable<AddressDTO>>(addresses);
            if (addressesDtos != null)
            {
                return new ResultDTO<IEnumerable<AddressDTO>>(0, "Sucesso.", addressesDtos);
            }
            else
            {
                return new ResultDTO<IEnumerable<AddressDTO>>(1, "Endereços não encontrados.", null);
            }
        }

        public ResultDTO<AddressDTO> GetById(int addressId)
        {
            Address address = _iAddressRepository.GetById(addressId);
            AddressDTO addressesDtos = _mapper.Map<AddressDTO>(address);
            if (addressesDtos != null)
            {
                return new ResultDTO<AddressDTO>(0, "Sucesso.", addressesDtos);
            }
            else
            {
                return new ResultDTO<AddressDTO>(1, "Endereço não encontrado.", null);
            }
        }


        public ResponseDTO Insert(AddressDTO addressDTO)
        {
            try
            {
                Address address = _mapper.Map<Address>(addressDTO);
                _iAddressRepository.Insert(address);
                return new ResponseDTO(0, "Endereço cadastrado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Endereço.");
            }
        }

        public ResponseDTO Update(AddressDTO addressDTO)
        {
            try
            {
                Address address = _mapper.Map<Address>(addressDTO);
                _iAddressRepository.Update(address);
                return new ResponseDTO(0, "Endereço alterado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Endereço.");
            }
        }


        public ResponseDTO Delete(int addressId)
        {
            Address address = _iAddressRepository.GetById(addressId);
            if (address != null)
            {
                _iAddressRepository.Delete(addressId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Endereço não encontrado.");
            }
        }

        public void Save()
        {
            _iAddressRepository.Save();
        }
    }
}
