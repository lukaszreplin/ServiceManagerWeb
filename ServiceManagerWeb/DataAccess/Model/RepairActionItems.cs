using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairActionItems
    {
        [Key]
        public int RepairActionItemId { get; set; }
        public int RepairActionId { get; set; }
        public int WarehouseItemId { get; set; }
        public int Quantity { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal GrossPrice { get; set; }

        [ForeignKey("RepairActionId")]
        [InverseProperty("RepairActionItems")]
        public RepairActions RepairAction { get; set; }
        [ForeignKey("WarehouseItemId")]
        [InverseProperty("RepairActionItems")]
        public WarehouseItems WarehouseItem { get; set; }
    }
}
