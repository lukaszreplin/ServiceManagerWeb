using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairActions
    {
        public RepairActions()
        {
            RepairActionItems = new HashSet<RepairActionItems>();
        }

        public int Id { get; set; }
        public int RepairActionDefinitionId { get; set; }
        public string PublicComment { get; set; }
        public string NonPublicComment { get; set; }
        public int RepairId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionDate { get; set; }
        public int? ActionUserId { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal GrossPrice { get; set; }

        [ForeignKey("ActionUserId")]
        [InverseProperty("RepairActions")]
        public Users ActionUser { get; set; }
        [ForeignKey("RepairId")]
        [InverseProperty("RepairActions")]
        public Repairs Repair { get; set; }
        [ForeignKey("RepairActionDefinitionId")]
        [InverseProperty("RepairActions")]
        public RepairActionDefinitions RepairActionDefinition { get; set; }
        [InverseProperty("RepairAction")]
        public ICollection<RepairActionItems> RepairActionItems { get; set; }
    }
}
