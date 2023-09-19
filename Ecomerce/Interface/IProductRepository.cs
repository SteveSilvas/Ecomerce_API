using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int Id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int Id);
        void Save();
    }
}
