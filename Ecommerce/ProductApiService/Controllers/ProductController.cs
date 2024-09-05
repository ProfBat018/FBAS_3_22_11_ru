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

    [HttpGet("GetAllProducts")]
    public async Task<IActionResult> GetAllProducts([FromQuery] int page, [FromQuery] int pagesize)
    {
        PaginatedList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(page, pagesize);

        return Ok(products);
    }
}

