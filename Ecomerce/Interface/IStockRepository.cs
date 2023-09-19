using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Interface
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetAll();
        Stock GetById(int stockId);
        void Insert(Stock stock);
        void Update(Stock stock);
        void Delete(int stockId);
        void Save();
    }
}

