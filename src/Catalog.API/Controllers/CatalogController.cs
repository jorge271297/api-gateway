using Catalog.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    [HttpGet("get-item-by-id/{id}")]
    public IActionResult GetItemById(int id)
    {
        Random random = new Random();

        CatalogItem item = new CatalogItem()
        {
            Id = id,
            Name = $"Item {id}",
            Description = $"Description item {id}",
            Price = random.Next(1, 10000)
        };

        return StatusCode(200, item);
    }

    [HttpPost("create-item")]
    public IActionResult CreateItem(CatalogItem catalog)
    {
        return StatusCode(200, new { Message = "Item created" });
    }

    [HttpPut("update-item")]
    public IActionResult UpdateItem(CatalogItem catalog)
    {
        return StatusCode(200, new { Message = "Item updated" });
    }

    [HttpDelete("delete-item")]
    public IActionResult DeleteItemById(int id)
    {
        return StatusCode(200, new { Message = "Item deleted" });
    }
}
