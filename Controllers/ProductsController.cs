using Microsoft.AspNetCore.Mvc;

namespace ProductsApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
  [HttpGet]
  public IActionResult GetProducts()
  {
    var products = new[]
    {
      new{ID = 1, Name = "Laptop", Price = 1200},
      new {ID = 2, Name= "Keyboard", Price= 80},
      new{ID= 3, Name="Mouse", Price= 40}
    };
    return Ok(products);
  }

  [HttpGet("{id}")]
  public IActionResult GetProduct(int id)
  {
    return Ok(new
    {
      Id = id,
      Name = "Laptop",
      Price = 1200
    });

  }
}