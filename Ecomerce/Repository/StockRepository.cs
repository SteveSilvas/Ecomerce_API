using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecomerce.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly DBContext _context;

        public StockRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Stock> GetAll()
        {
            return _context.Stocks.ToList();
        }

        public Stock GetById(int stockId)
        {
            try
            {
                return _context.Stocks.Find(stockId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(Stock stock)
        {
            _context.Stocks.Add(stock);
            Save();
        }

        public void Update(Stock stock)
        {
            _context.Stocks.Update(stock);
            Save();
        }

        public void Delete(int stockId)
        {
            Stock stock = GetById(stockId);

            if (stock != null)
            {
                _context.Stocks.Remove(stock);
                Save();
            }
            else
            {
                throw new ArgumentException("Stock not found.");
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
