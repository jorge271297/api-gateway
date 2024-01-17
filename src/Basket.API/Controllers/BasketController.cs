using Basket.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Basket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private CustomerBasket basket = new CustomerBasket()
        {
            BuyerId = null,
            Items = new List<BasketItem>() {
                new BasketItem() { Id = Guid.NewGuid().ToString(), UnitPrice = 0, OldUnitPrice = 0, ProductName = "", PictureUrl = "", ProductId = new Random().Next(1, 10000), Quantity = new Random().Next(1, 10000) },
                new BasketItem() { Id = Guid.NewGuid().ToString(), UnitPrice = 0, OldUnitPrice = 0, ProductName = "", PictureUrl = "", ProductId = new Random().Next(1, 10000), Quantity = new Random().Next(1, 10000) },
                new BasketItem() { Id = Guid.NewGuid().ToString(), UnitPrice = 0, OldUnitPrice = 0, ProductName = "", PictureUrl = "", ProductId = new Random().Next(1, 10000), Quantity = new Random().Next(1, 10000) },
                new BasketItem() { Id = Guid.NewGuid().ToString(), UnitPrice = 0, OldUnitPrice = 0, ProductName = "", PictureUrl = "", ProductId = new Random().Next(1, 10000), Quantity = new Random().Next(1, 10000) },
            }
        };

        [HttpGet("get-basket")]
        public IActionResult GetBasket(string buyerId)
        {
            basket.BuyerId = buyerId;
            return StatusCode(200, basket);
        }

        [HttpPut("update-basket")]
        public IActionResult UpdateBasket(CustomerBasket customerBasket)
        {
            return StatusCode(200, customerBasket);
        }

        [HttpDelete("delete-basket")]
        public IActionResult DeleteBasket(CustomerBasket customerBasket)
        {
            return StatusCode(200, new CustomerBasket());
        }
    }
}
