using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Youtube.Controllers;

[Route("api/Values/[action]")]
[ApiController]
public sealed class ValuesController : ControllerBase
{
    [HttpGet("{x}/{y}/{name}")]//burada seçtiğimiz tip bir kesinlik değil
    //[HttpPost]//burada seçtiğimiz tip bir kesinlik değil
    //[HttpPut]//burada seçtiğimiz tip bir kesinlik değil
    //[HttpDelete]//burada seçtiğimiz tip bir kesinlik değil
    public IActionResult Hello(int x, int y, string name)
    {
        return Ok(new { Message = (x + y) * 10 });
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto request)
    {
        return StatusCode(200, new { Message = "Hello World" });
    }
}


public class CreateProductDto
{
    public Product Product { get; set; }
    public Category Category { get; set; }
}

public class Product
{
    public string Name { get; set; } = string.Empty;
}

public class Category
{
    public string Name { get; set; } = string.Empty;
}