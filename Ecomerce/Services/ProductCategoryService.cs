using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _iProductCategoryRepository;
        private readonly IMapper _mapper;
        public ProductCategoryService(IProductCategoryRepository iProductCategoryRepository, IMapper mapper)
        {
            _iProductCategoryRepository = iProductCategoryRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<ProductCategory>> GetAll()
        {
            IEnumerable<ProductCategory> categories = _iProductCategoryRepository.GetAll();
            if (categories != null)
            {
                return new ResultDTO<IEnumerable<ProductCategory>>(0, "Sucesso.", categories);
            }
            else
            {
                return new ResultDTO<IEnumerable<ProductCategory>>(1, "Erro ao carregar as categorias de produtos.", null);
            }
        }

        public ResultDTO<ProductCategory> GetById(int categoryId)
        {
            ProductCategory category = _iProductCategoryRepository.GetById(categoryId);
            if (category != null)
            {
                return new ResultDTO<ProductCategory>(0, "Sucesso.", category);
            }
            else
            {
                return new ResultDTO<ProductCategory>(1, "Categoria não encontrada.", null);
            }
        }


        public ResponseDTO Insert(ProductCategory category)
        {
            try
            {
                _iProductCategoryRepository.Insert(category);
                return new ResponseDTO(0, "Categoria cadastrada com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Categoria.");
            }
        }

        public ResponseDTO Update(ProductCategory category)
        {
            try
            {
                _iProductCategoryRepository.Update(category);
                return new ResponseDTO(0, "Categoria alterada com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Categoria.");
            }
        }


        public ResponseDTO Delete(int categoryId)
        {
            var category = _iProductCategoryRepository.GetById(categoryId);
            if (category != null)
            {
                _iProductCategoryRepository.Delete(categoryId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Employee not found.");
            }
        }

        public void Save()
        {
            _iProductCategoryRepository.Save();
        }
    }
}
