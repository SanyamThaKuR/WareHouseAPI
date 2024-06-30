using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseAPI.Model
{
	public class WareHouse
	{
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
       public string name { get; set; }
        [Required(ErrorMessage = "Number is required.")]
        public int WareHouseNumber { get; set; }
        
    }
}

