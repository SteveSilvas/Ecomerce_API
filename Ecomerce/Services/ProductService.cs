using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _iProductRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository iProductRepository, IMapper mapper)
        {
            _iProductRepository = iProductRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<Product>> GetAll()
        {
            IEnumerable<Product> products = _iProductRepository.GetAll();
            if (products != null)
            {
                return new ResultDTO<IEnumerable<Product>>(0, "Sucesso.", products);
            }
            else
            {
                return new ResultDTO<IEnumerable<Product>>(1, "Erro ao carregar a lista de Produtos.", null);
            }
        }

        public ResultDTO<Product> GetById(int Id)
        {
            Product product = _iProductRepository.GetById(Id);
            if (product != null)
            {
                return new ResultDTO<Product>(0, "Sucesso.", product);
            }
            else
            {
                return new ResultDTO<Product>(1, "Produto não encontrado.", null);
            }
        }

        public ResponseDTO Insert(Product product)
        {
            try
            {
                _iProductRepository.Insert(product);
                return new ResponseDTO(0, "Produto cadastrado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Produto.");
            }
        }

        public ResponseDTO Update(Product product)
        {
            try
            {
                _iProductRepository.Update(product);
                return new ResponseDTO(0, "Produto alterado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Produto.");
            }
        }

        public ResponseDTO Delete(int Id)
        {
            var product = _iProductRepository.GetById(Id);
            if (product != null)
            {
                _iProductRepository.Delete(Id);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Produto não encontrado.");
            }
        }

        public void Save()
        {
            _iProductRepository.Save();
        }
    }
}
