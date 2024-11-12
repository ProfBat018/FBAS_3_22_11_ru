using Azure;
using Microsoft.AspNetCore.Mvc;
using ProductData.Models;
using ProductRepository.Interfaces;

namespace ProductApiService.Controllers;

[ApiController]
public class ProductController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("Products/{page}/{pagesize}")]
    
    public async Task<IActionResult> GetAllPaginatedProducts(int page, int pagesize)
    {
        PaginatedList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(page, pagesize);

        return Ok(products);
    }
    
    [HttpGet("Products/All")]
    
    public async Task<IActionResult> GetAllProducts()
    {
        List<Product> products = await _unitOfWork.ProductRepository.GetAllAsync() as List<Product>;

        return Ok(products);
    }
}

