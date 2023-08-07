using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryService _iProductCategoryService;

        public ProductCategoryController(IProductCategoryService iProductCategory)
        {
            _iProductCategoryService = iProductCategory;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<ProductCategory>> GetAllProductCategories()
        {
            return _iProductCategoryService.GetAll();
        }

        [HttpGet]
        public ResultDTO<ProductCategory> GetProductCategoryById(int categoryId)
        {
            return _iProductCategoryService.GetById(categoryId);
        }

        [HttpPost]
        public ActionResult AddProductCategory(ProductCategory category)
        {
            var result = _iProductCategoryService.Insert(category);
            return result.ResultCode == 0 ? (ActionResult)Ok("Categoria registrada com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditProductCategory(ProductCategory category)
        {
            var result = _iProductCategoryService.Update(category);
            return result.ResultCode == 0 ? (ActionResult)Ok("Categoria Alterada com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteProductCategory(int categoryId)
        {
            var result = _iProductCategoryService.Delete(categoryId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
