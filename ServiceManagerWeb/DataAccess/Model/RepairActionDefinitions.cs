using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairActionDefinitions
    {
        public RepairActionDefinitions()
        {
            RepairActions = new HashSet<RepairActions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal GrossPrice { get; set; }
        public int TaxRateId { get; set; }

        [ForeignKey("TaxRateId")]
        [InverseProperty("RepairActionDefinitions")]
        public TaxRates TaxRate { get; set; }
        [InverseProperty("RepairActionDefinition")]
        public ICollection<RepairActions> RepairActions { get; set; }
    }
}
