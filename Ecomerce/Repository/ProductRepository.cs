using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext _context;

        public ProductRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int productId)
        {
            try
            {
                return _context.Products.Find(productId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
            Save();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            Save();
        }

        public void Delete(int productId)
        {
            Product product = GetById(productId);

            if (product != null)
            {
                _context.Products.Remove(product);
                Save();
            }
            else
            {
                throw new ArgumentException("Department not found.");
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
