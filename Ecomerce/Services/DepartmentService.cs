using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _iDepartmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository iDepartmentRepository, IMapper mapper)
        {
            _iDepartmentRepository = iDepartmentRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<DepartmentDTO>> GetAll()
        {
            IEnumerable<Department> departments = _iDepartmentRepository.GetAll();
            IEnumerable<DepartmentDTO> departmentsDTO = _mapper.Map<IEnumerable<DepartmentDTO>>(departments);
            if (departments != null)
            {
                return new ResultDTO<IEnumerable<DepartmentDTO>>(0, "Sucesso.", departmentsDTO);
            }
            else
            {
                return new ResultDTO<IEnumerable<DepartmentDTO>>(1, "No employees found.", null);
            }
        }

        public ResultDTO<DepartmentDTO> GetById(int departmentId)
        {
            Department department = _iDepartmentRepository.GetById(departmentId);
            DepartmentDTO departmentDTO = _mapper.Map<DepartmentDTO>(department);
            if (departmentDTO != null)
            {
                return new ResultDTO<DepartmentDTO>(0, "Sucesso.", departmentDTO);
            }
            else
            {
                return new ResultDTO<DepartmentDTO>(1, "Departamento não encontrado.", null);
            }
        }


        public ResponseDTO Insert(DepartmentDTO departmentDTO)
        {
            try
            {
                Department department = _mapper.Map<Department>(departmentDTO);

                _iDepartmentRepository.Insert(department);
                return new ResponseDTO(0, "Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao inserir Departamento.");
            }
        }

        public ResponseDTO Update(DepartmentDTO departmentDTO)
        {
            try
            {
                Department department = _mapper.Map<Department>(departmentDTO);
                _iDepartmentRepository.Update(department);
                return new ResponseDTO(0, "Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Departamento.");
            }
        }


        public ResponseDTO Delete(int departmentId)
        {
            var department = _iDepartmentRepository.GetById(departmentId);
            if (department != null)
            {
                _iDepartmentRepository.Delete(departmentId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Employee not found.");
            }
        }

        public ResponseDTO Save()
        {
            try
            {
                _iDepartmentRepository.Save();
                return new ResponseDTO(0, "Sucesso.");
            }
            catch
            {
                return new ResponseDTO(1, "Erro.");
            }
        }
    }
}
