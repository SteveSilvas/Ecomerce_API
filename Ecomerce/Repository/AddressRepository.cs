using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DBContext _context;

        public AddressRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Address> GetAll()
        {
            return _context.Addresses.ToList();
        }

        public Address GetById(int addressId)
        {
            try
            {
                return _context.Addresses.Find(addressId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(Address address)
        {
            _context.Addresses.Add(address);
            Save();
        }

        public void Update(Address address)
        {
            _context.Addresses.Update(address);
            Save();
        }

        public void Delete(int addressId)
        {
            Address address = GetById(addressId);

            if (address != null)
            {
                _context.Addresses.Remove(address);
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
