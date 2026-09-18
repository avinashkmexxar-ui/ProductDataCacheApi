using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using ProductDataCacheApi.Application.DTOs;
using ProductDataCacheApi.Application.Interfaces;
using ProductDataCacheApi.Domain.Entities;

namespace ProductDataCacheApi.API.Controllers
{
    [ApiController] 
    [Route("api/products")]
    [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService) => _productService = productService;

        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyList<ProductDetailDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetList(CancellationToken cancellationToken) =>
        Ok(await _productService.GetListAsync(cancellationToken));

         
    }
}
