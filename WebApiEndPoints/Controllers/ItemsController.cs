using Microsoft.AspNetCore.Mvc;
using WebApiEndPoints.Model;

namespace WebApiEndPoints.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ItemsController : ControllerBase
    {
        public static List<Item> _item = new List<Item>
        {
            new Item { Id = 1, Title = "Weather", Description = "Weather changes unexpectadly"},
            new Item { Id = 2, Title = "Temparature", Description = "Temperature Increases in Summer"}
        };

        [HttpGet]

        public IActionResult GetItems()
        {

        }
    }
}
