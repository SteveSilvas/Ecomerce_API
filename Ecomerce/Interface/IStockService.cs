using Ecomerce.DTO;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Interface
{
    public interface IStockService
    {
        ResultDTO<IEnumerable<Stock>> GetAll();
        ResultDTO<Stock> GetById(int stockId);
        ResultDTO<Stock> GetByProductId(int productId); // Novo método de busca
        ResponseDTO Insert(Stock stock);
        ResponseDTO Update(Stock stock);
        ResponseDTO Delete(int stockId);
        void Save();
    }
}
