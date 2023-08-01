using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class AddressStateRepository : IAddressStateRepository
    {
        private readonly DBContext _context;

        public AddressStateRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<AddressState> GetAll()
        {
            return _context.AddressStates.ToList();
        }

        public AddressState GetById(int addressStateId)
        {
            try
            {
                return _context.AddressStates.Find(addressStateId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(AddressState addressState)
        {
            _context.AddressStates.Add(addressState);
            Save();
        }

        public void Update(AddressState addressState)
        {
            _context.AddressStates.Update(addressState);
            Save();
        }

        public void Delete(int addressStateId)
        {
            AddressState addressState = GetById(addressStateId);

            if (addressState != null)
            {
                _context.AddressStates.Remove(addressState);
                Save();
            }
            else
            {
                throw new ArgumentException("Estado não encontrado.");
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
