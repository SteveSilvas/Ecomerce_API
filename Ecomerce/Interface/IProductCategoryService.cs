using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IProductCategoryService
    {
        ResultDTO<IEnumerable<ProductCategory>> GetAll();
        ResultDTO<ProductCategory> GetById(int productCategoryId);
        ResponseDTO Insert(ProductCategory productCategory);
        ResponseDTO Update(ProductCategory productCategory);
        ResponseDTO Delete(int productCategoryId);
        void Save();
    }
}
