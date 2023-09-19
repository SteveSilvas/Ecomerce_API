using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public ResultDTO<Stock> GetStockByProductId(int productId)
        {
            try
            {
                var result = _stockService.GetByProductId(productId);
                if (result.ResultCode == 0)
                {
                    return result;
                }
                else
                {
                    return new ResultDTO<Stock>(result.ResultCode, "Estoque não encontrado para o produto especificado.", null);
                }
            }
            catch (Exception ex)
            {
                return new ResultDTO<Stock>(1, "Ocorreu um erro ao buscar o estoque.", null);
            }
        }

        [HttpGet]
        public ResultDTO<IEnumerable<Stock>> GetAllStocks()
        {
            return _stockService.GetAll();
        }

        [HttpGet]
        public ResultDTO<Stock> GetStockById(int stockId)
        {
            return _stockService.GetById(stockId);
        }

        [HttpPost]
        public ActionResult AddStock(Stock stock)
        {
            var result = _stockService.Insert(stock);
            return result.ResultCode == 0 ? (ActionResult)Ok("Estoque registrado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditStock(Stock stock)
        {
            var result = _stockService.Update(stock);
            return result.ResultCode == 0 ? (ActionResult)Ok("Estoque alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteStock(int stockId)
        {
            var result = _stockService.Delete(stockId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro de estoque removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
