using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Youtube.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    public static List<Product> Products { get; set; } = new();

    [HttpPost]
    public IActionResult Create(Product product)
    {
        Products.Add(product);

        return Created();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Products);
    }
}
