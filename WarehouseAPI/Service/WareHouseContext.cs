using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WarehouseAPI.Model;

namespace WarehouseAPI.Service
{
	public class WareHouseContext :DbContext
	{
		public WareHouseContext(DbContextOptions<WareHouseContext> options)
            : base(options)
        {
        }

        public DbSet<WareHouse> Warehouses { get; set; }
    }
}


