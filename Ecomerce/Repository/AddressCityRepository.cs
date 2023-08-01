using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class AddressCityRepository : IAddressCityRepository
    {
        private readonly DBContext _context;

        public AddressCityRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<AddressCity> GetAll()
        {
            return _context.AddressCities.ToList();
        }

        public AddressCity GetById(int addressCityId)
        {
            try
            {
                return _context.AddressCities.Find(addressCityId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(AddressCity addressCity)
        {
            _context.AddressCities.Add(addressCity);
            Save();
        }

        public void Update(AddressCity addressCity)
        {
            _context.AddressCities.Update(addressCity);
            Save();
        }

        public void Delete(int addressCityId)
        {
            AddressCity addressCity = GetById(addressCityId);

            if (addressCity != null)
            {
                _context.AddressCities.Remove(addressCity);
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
