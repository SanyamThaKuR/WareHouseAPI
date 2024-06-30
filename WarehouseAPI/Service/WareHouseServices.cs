using System;
using WarehouseAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

// Created originally by ==================> SANYAM

namespace WarehouseAPI.Service
{
    public class WareHouseServices : IWareHouseServices
    {

        private readonly WareHouseContext _context;

        // default constructor to ini. the context
        public WareHouseServices(WareHouseContext context) { _context = context; }

        // Add warehouse to dbset
        public void AddWarehouse(WareHouse warehouse)
        {
            _context.Warehouses.Add(warehouse);   // add to dbset
            _context.SaveChanges();
        }

        public void DeleteWarehouse(int id)
        {
            var delete = _context.Warehouses.Where(b => b.ID == id).FirstOrDefault();
            //base condition ======>
            if(delete != null) { _context.Warehouses.Remove(delete); }
                
        }

        public IEnumerable<WareHouse> GetAllWareHouses()
        {
            return _context.Warehouses.ToList();
        }

        public WareHouse GetWarehouseByNumber(int warehouseNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateWarehouse(WareHouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}

