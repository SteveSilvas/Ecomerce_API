using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        public ResultDTO<IEnumerable<Stock>> GetAll()
        {
            IEnumerable<Stock> stocks = _stockRepository.GetAll();
            if (stocks != null)
            {
                return new ResultDTO<IEnumerable<Stock>>(0, "Sucesso.", stocks);
            }
            else
            {
                return new ResultDTO<IEnumerable<Stock>>(1, "Erro ao carregar o estoque.", null);
            }
        }

        public ResultDTO<Stock> GetById(int stockId)
        {
            Stock stock = _stockRepository.GetById(stockId);
            if (stock != null)
            {
                return new ResultDTO<Stock>(0, "Sucesso.", stock);
            }
            else
            {
                return new ResultDTO<Stock>(1, "Estoque não encontrado.", null);
            }
        }
        public ResultDTO<Stock> GetByProductId(int productId)
        {
            Stock stock = _stockRepository.GetAll().FirstOrDefault(s => s.ProductId == productId);
            if (stock != null)
            {
                return new ResultDTO<Stock>(0, "Sucesso.", stock);
            }
            else
            {
                return new ResultDTO<Stock>(1, "Estoque não encontrado para o produto especificado.", null);
            }
        }

        public ResponseDTO Insert(Stock stock)
        {
            try
            {
                _stockRepository.Insert(stock);
                return new ResponseDTO(0, "Estoque cadastrado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao cadastrar Estoque.");
            }
        }

        public ResponseDTO Update(Stock stock)
        {
            try
            {
                _stockRepository.Update(stock);
                return new ResponseDTO(0, "Estoque alterado com Sucesso.");
            }
            catch (Exception ex)
            {
                return new ResponseDTO(1, "Erro ao atualizar Estoque.");
            }
        }

        public ResponseDTO Delete(int stockId)
        {
            var stock = _stockRepository.GetById(stockId);
            if (stock != null)
            {
                _stockRepository.Delete(stockId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Estoque não encontrado.");
            }
        }

        public void Save()
        {
            _stockRepository.Save();
        }
    }
}
