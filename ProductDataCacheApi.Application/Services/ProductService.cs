using AutoMapper;
using ProductDataCacheApi.Application.DTOs;
using ProductDataCacheApi.Application.Interfaces;
using ProductDataCacheApi.Domain.Entities;
using ProductDataCacheApi.Infrastructure.Persistence.Interfaces;
using ProductDataCacheApi.Shared.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataCacheApi.Application.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Result<ProductDetailDto>> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<ProductDetailDto>> GetListAsync(CancellationToken cancellationToken)
        {
            IReadOnlyList<Product?> products = await _productRepository.GetListAsync(cancellationToken);
            if (products.Count == 0)
            {

                List<Product> external =
                [
                    new Product
                        {
                            Id = 1,
                            Title = "Testing",
                            Description = "Hard coded",
                            Price = 99.99m,
                            Stock = 10
                        }
                ];

                await _productRepository.UpsertAsync(external, cancellationToken);
                products = await _productRepository.GetListAsync(cancellationToken);
            }
            return _mapper.Map<List<ProductDetailDto>>(products);

        }
    }
}
