using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressService
    {
        ResultDTO<IEnumerable<Address>> GetAll();
        ResultDTO<Address> GetById(int addressId);
        ResponseDTO Insert(Address address);
        ResponseDTO Update(Address address);
        ResponseDTO Delete(int addressId);
        void Save();
    }
}
