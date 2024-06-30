using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseAPI.Model;
using WarehouseAPI.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHouseController : ControllerBase
    {
        // Dependency Injection  (ioS)================>
        private readonly IWareHouseServices _services;

        public WareHouseController(IWareHouseServices wareHouseServices)
        {
            _services = wareHouseServices;       // inject through ctor to use sevices
        }

        // GET: api/WareHouse
        [HttpGet( Name = "GetWareHouse")]
        public ActionResult<IEnumerable<WareHouse>> GetWareHouse( )
        {
            var value = _services.GetAllWareHouses();
            return Ok(value);
        }
        [HttpPost]
        public ActionResult<WareHouse> AddWarehouse([FromBody] WareHouse warehouse)
        {
            if (warehouse == null)
            {
                return BadRequest();
            }
            _services.AddWarehouse(warehouse);
            return CreatedAtAction(nameof(GetWareHouse), new { warehouseNumber = warehouse.WareHouseNumber }, warehouse);
        }



    }
}

