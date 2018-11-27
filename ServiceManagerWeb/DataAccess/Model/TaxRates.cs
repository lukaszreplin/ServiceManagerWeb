using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class TaxRates
    {
        public TaxRates()
        {
            RepairActionDefinitions = new HashSet<RepairActionDefinitions>();
            WarehouseItems = new HashSet<WarehouseItems>();
        }

        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }

        [InverseProperty("TaxRate")]
        public ICollection<RepairActionDefinitions> RepairActionDefinitions { get; set; }
        [InverseProperty("TaxRate")]
        public ICollection<WarehouseItems> WarehouseItems { get; set; }
    }
}
