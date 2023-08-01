using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DBContext _context;

        public EmployeeRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int employeeId)
        {
            try
            {
                return _context.Employees.Find(employeeId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
            Save();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            Save();
        }

        public void Delete(int employeeId)
        {
            Employee employee = GetById(employeeId);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                Save();
            }
            else
            {
                throw new ArgumentException("Employee not found.");
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
