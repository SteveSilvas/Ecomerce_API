using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Ecomerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        IProductService _iProductService;

        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<Product>> GetAllProducts()
        {
            return _iProductService.GetAll();
        }

        [HttpGet]
        public ResultDTO<Product> GetProductById(int productId)
        {
            return _iProductService.GetById(productId);
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            var result = _iProductService.Insert(product);
            return result.ResultCode == 0 ? (ActionResult)Ok("Produto registrado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditProduct(Product product)
        {
            var result = _iProductService.Update(product);
            return result.ResultCode == 0 ? (ActionResult)Ok("Produto Alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int productId)
        {
            var result = _iProductService.Delete(productId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }

    }
}
