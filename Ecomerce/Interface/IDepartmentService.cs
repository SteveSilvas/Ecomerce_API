using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IDepartmentService
    {
        ResultDTO<IEnumerable<DepartmentDTO>> GetAll();
        ResultDTO<DepartmentDTO> GetById(int departmentId);
        ResponseDTO Insert(DepartmentDTO department);
        ResponseDTO Update(DepartmentDTO department);
        ResponseDTO Delete(int departmentId);
        ResponseDTO Save();
    }
}
