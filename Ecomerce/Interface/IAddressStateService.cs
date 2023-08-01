using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressStateService
    {
        ResultDTO<IEnumerable<AddressState>> GetAll();
        ResultDTO<AddressState> GetById(int addressStateId);
        ResponseDTO Insert(AddressState addressState);
        ResponseDTO Update(AddressState addressState);
        ResponseDTO Delete(int addressStateId);
        void Save();
    }
}
