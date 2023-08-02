using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressService
    {
        ResultDTO<IEnumerable<AddressDTO>> GetAll();
        ResultDTO<AddressDTO> GetById(int addressId);
        ResponseDTO Insert(AddressDTO address);
        ResponseDTO Update(AddressDTO address);
        ResponseDTO Delete(int addressId);
        void Save();
    }
}
