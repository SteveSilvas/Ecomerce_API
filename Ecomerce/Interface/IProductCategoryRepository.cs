using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetAll();
        ProductCategory GetById(int categoryId);
        void Insert(ProductCategory category);
        void Update(ProductCategory category);
        void Delete(int categoryId);
        void Save();
    }
}
