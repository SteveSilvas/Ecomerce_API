using Ecomerce.DTO;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IAddressStateRepository
    {
        IEnumerable<AddressState> GetAll();
        AddressState GetById(int addressStateId);
        void Insert(AddressState addressState);
        void Update(AddressState addressState);
        void Delete(int addressStateId);
        void Save();
    }
}
