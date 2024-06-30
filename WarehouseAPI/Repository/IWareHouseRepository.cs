using System;
using WarehouseAPI.Model;

namespace WarehouseAPI.Repository
{
	public interface IWareHouseRepository
	{
        IEnumerable<WareHouse> GetAllWarehouses();
        WareHouse GetWarehouseByNumber(int warehouseNumber);
        void AddWarehouse(WareHouse warehouse);
        void UpdateWarehouse(WareHouse warehouse);
        void DeleteWarehouse(int  warehouseNumber);
    }
}

