using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Repairs
    {
        public Repairs()
        {
            RepairActions = new HashSet<RepairActions>();
            RepairComments = new HashSet<RepairComments>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CreatedUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AcceptanceDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ExpectedComplentionDate { get; set; }
        public int DeviceId { get; set; }
        public decimal ExpectedCost { get; set; }
        public string DamageDescription { get; set; }
        public string Comment { get; set; }
        public int RepairTypeId { get; set; }
        public int RepairStatusId { get; set; }
        public string RepairNumber { get; set; }
        public string RepairDescription { get; set; }
        public int? TechnicianId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ComplentionDate { get; set; }
        public decimal NetCost { get; set; }
        public decimal GrossCost { get; set; }

        [ForeignKey("ClientId")]
        [InverseProperty("Repairs")]
        public Clients Client { get; set; }
        [ForeignKey("DeviceId")]
        [InverseProperty("Repairs")]
        public Devices Device { get; set; }
        [ForeignKey("RepairStatusId")]
        [InverseProperty("Repairs")]
        public RepairStatus RepairStatus { get; set; }
        [ForeignKey("RepairTypeId")]
        [InverseProperty("Repairs")]
        public RepairTypes RepairType { get; set; }
        [ForeignKey("TechnicianId")]
        [InverseProperty("Repairs")]
        public Users Technician { get; set; }
        [InverseProperty("Repair")]
        public ICollection<RepairActions> RepairActions { get; set; }
        [InverseProperty("Repair")]
        public ICollection<RepairComments> RepairComments { get; set; }
    }
}
