using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressCityService
    {
        ResultDTO<IEnumerable<AddressCity>> GetAll();
        ResultDTO<AddressCity> GetById(int addressCityId);
        ResponseDTO Insert(AddressCity addressCity);
        ResponseDTO Update(AddressCity addressCity);
        ResponseDTO Delete(int addressCityId);
        void Save();
    }
}
