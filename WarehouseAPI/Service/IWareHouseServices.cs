using System;
using WarehouseAPI.Model;


// Created originally by ==================> SANYAM
namespace WarehouseAPI.Service
{
	public interface IWareHouseServices
	{
        //Retrieves all warehouses.
        public IEnumerable<WareHouse> GetAllWareHouses();

        //Retrieves a specific warehouse by its warehouse number.
        public WareHouse GetWarehouseByNumber(int warehouseNumber);

        //Adds a new warehouse to the system.
        void AddWarehouse(WareHouse warehouse);

        //Update a new warehouse to the system.
        void UpdateWarehouse(WareHouse warehouse);

        //Delete data.
        void DeleteWarehouse(int warehouseNumber);// using ID column



    }
}

