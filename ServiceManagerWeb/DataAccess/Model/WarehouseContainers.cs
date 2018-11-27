using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class WarehouseContainers
    {
        public WarehouseContainers()
        {
            InverseParent = new HashSet<WarehouseContainers>();
            WarehouseItems = new HashSet<WarehouseItems>();
        }

        public int Id { get; set; }
        public string Symbol { get; set; }
        public int? ParentId { get; set; }
        public int WarehouseContainerTypeId { get; set; }
        public bool CanStoreItems { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("InverseParent")]
        public WarehouseContainers Parent { get; set; }
        [ForeignKey("WarehouseContainerTypeId")]
        [InverseProperty("WarehouseContainers")]
        public WarehouseContainerTypes WarehouseContainerType { get; set; }
        [InverseProperty("Parent")]
        public ICollection<WarehouseContainers> InverseParent { get; set; }
        [InverseProperty("WarehouseContainer")]
        public ICollection<WarehouseItems> WarehouseItems { get; set; }
    }
}
