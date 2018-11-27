using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class WarehouseContainerTypes
    {
        public WarehouseContainerTypes()
        {
            WarehouseContainers = new HashSet<WarehouseContainers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("WarehouseContainerType")]
        public ICollection<WarehouseContainers> WarehouseContainers { get; set; }
    }
}
