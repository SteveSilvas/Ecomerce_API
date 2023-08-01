using Ecomerce.Model;

namespace Ecomerce.Interface
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(int departmentId);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int departmentId);
        void Save();
    }
}

