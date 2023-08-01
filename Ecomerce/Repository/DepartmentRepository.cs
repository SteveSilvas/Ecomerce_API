using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ecomerce.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DBContext _context;

        public DepartmentRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int departmentId)
        {
            try
            {
                return _context.Departments.Find(departmentId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Insert(Department department)
        {
            _context.Departments.Add(department);
            Save();
        }

        public void Update(Department department)
        {
            _context.Departments.Update(department);
            Save();
        }

        public void Delete(int departmentId)
        {
            Department department = GetById(departmentId);

            if (department != null)
            {
                _context.Departments.Remove(department);
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
