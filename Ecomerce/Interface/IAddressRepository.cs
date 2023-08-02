using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAll();
        Address GetById(int addressId);
        void Insert(Address address);
        void Update(Address address);
        void Delete(int addressId);
        void Save();
    }
}
