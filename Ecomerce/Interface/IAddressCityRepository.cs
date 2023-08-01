using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressCityRepository
    {
        IEnumerable<AddressCity> GetAll();
        AddressCity GetById(int addressCityId);
        void Insert(AddressCity addressCity);
        void Update(AddressCity addressCity);
        void Delete(int addressCityId);
        void Save();
    }
}
