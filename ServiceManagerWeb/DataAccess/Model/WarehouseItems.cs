using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class WarehouseItems
    {
        public WarehouseItems()
        {
            RepairActionItems = new HashSet<RepairActionItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string ManufacturerSymbol { get; set; }
        public int Quantity { get; set; }
        public int WarehouseItemTypeId { get; set; }
        public int WarehouseContainerId { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal GrossPrice { get; set; }
        public int? TaxRateId { get; set; }

        [ForeignKey("TaxRateId")]
        [InverseProperty("WarehouseItems")]
        public TaxRates TaxRate { get; set; }
        [ForeignKey("WarehouseContainerId")]
        [InverseProperty("WarehouseItems")]
        public WarehouseContainers WarehouseContainer { get; set; }
        [ForeignKey("WarehouseItemTypeId")]
        [InverseProperty("WarehouseItems")]
        public WarehouseItemTypes WarehouseItemType { get; set; }
        [InverseProperty("WarehouseItem")]
        public ICollection<RepairActionItems> RepairActionItems { get; set; }
    }
}
