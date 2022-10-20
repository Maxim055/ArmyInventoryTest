 using ArmyInventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArmyInventory.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryControler : ControllerBase
    {

        private readonly InventoryRepository _inventoryRepository;

        public InventoryControler( )
        {
           
           _inventoryRepository =  new InventoryRepository();
            
        }

        [HttpGet()]

        public IActionResult GetCategory()
        {
            return Ok(_inventoryRepository.GetCategory());
        }

        [HttpPost]
        public IActionResult AddCategoryAsync(string Categoryname)
        {
            return Ok(_inventoryRepository.AddCategoryAsync(Categoryname));
        }



    }
}
