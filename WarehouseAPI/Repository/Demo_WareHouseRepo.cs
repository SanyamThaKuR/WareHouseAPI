using System;
using WarehouseAPI.Model;

namespace WarehouseAPI.Repository
{
	public class Demo_WareHouseRepo : IWareHouseRepository
	{
        private readonly List<WareHouse> _warehouses = new List<WareHouse>
        {
            new WareHouse { WareHouseNumber = 213, Name = "Montreal" },
            new WareHouse { WareHouseNumber = 746, Name = "Drummondville" },
            new WareHouse { WareHouseNumber = 933, Name = "Sherbrooke" },
            new WareHouse { WareHouseNumber = 738, Name = "Saguenay" },
            new WareHouse { WareHouseNumber = 219, Name = "Shawinigan" }

        };

        public void AddWarehouse(WareHouse warehouse)
        {
            _warehouses.Add(warehouse);
        }

        public void DeleteWarehouse(int  warehouseNumber)
        {
            var warehouse = _warehouses.FirstOrDefault(w => w.WareHouseNumber == warehouseNumber);
            if (warehouse != null)
            {
                _warehouses.Remove(warehouse);
            }
        }

        public IEnumerable<WareHouse> GetAllWarehouses()
        {
            return _warehouses; ;
        }

        public WareHouse GetWarehouseByNumber(int warehouseNumber)
        {
            return _warehouses.FirstOrDefault(w => w.WareHouseNumber == warehouseNumber);
        }

        public void UpdateWarehouse(WareHouse warehouse)
        {
            var index = _warehouses.FindIndex(w => w.WareHouseNumber == warehouse.WareHouseNumber);
            if (index != -1)
            {
                _warehouses[index] = warehouse;
            }
        }
    }
}

