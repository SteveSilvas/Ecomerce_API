using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IProductService
    {
        ResultDTO<IEnumerable<Product>> GetAll();
        ResultDTO<Product> GetById(int productId);
        ResponseDTO Insert(Product product);
        ResponseDTO Update(Product product);
        ResponseDTO Delete(int productId);
        void Save();
    }
}
