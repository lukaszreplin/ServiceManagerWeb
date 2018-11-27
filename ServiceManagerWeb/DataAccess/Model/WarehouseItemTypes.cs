using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class WarehouseItemTypes
    {
        public WarehouseItemTypes()
        {
            WarehouseItems = new HashSet<WarehouseItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("WarehouseItemType")]
        public ICollection<WarehouseItems> WarehouseItems { get; set; }
    }
}
