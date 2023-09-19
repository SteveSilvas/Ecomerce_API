using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;

namespace Ecomerce.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly DBContext _context;

        public ProductCategoryRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }

        public ProductCategory GetById(int productCategoryId)
        {
            try
            {
                return _context.ProductCategories.Find(productCategoryId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(ProductCategory productCategory)
        {
            _context.ProductCategories.Add(productCategory);
            Save();
        }

        public void Update(ProductCategory productCategory)
        {
            _context.ProductCategories.Update(productCategory);
            Save();
        }

        public void Delete(int productCategoryId)
        {
            ProductCategory productCategory = GetById(productCategoryId);

            if (productCategory != null)
            {
                _context.ProductCategories.Remove(productCategory);
                Save();
            }
            else
            {
                throw new ArgumentException("Product not found.");
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
