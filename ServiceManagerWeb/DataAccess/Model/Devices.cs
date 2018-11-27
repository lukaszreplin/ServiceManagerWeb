using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Devices
    {
        public Devices()
        {
            Repairs = new HashSet<Repairs>();
        }

        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Condition { get; set; }
        public decimal? Worth { get; set; }
        public string IncludedAccesories { get; set; }
        public string Comments { get; set; }
        public string InternalComments { get; set; }
        public int DeviceStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? OwnerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserId { get; set; }

        [ForeignKey("CreatedUserId")]
        [InverseProperty("DevicesCreatedUser")]
        public Users CreatedUser { get; set; }
        [ForeignKey("DeviceStatusId")]
        [InverseProperty("Devices")]
        public DeviceStatus DeviceStatus { get; set; }
        [ForeignKey("DeviceTypeId")]
        [InverseProperty("Devices")]
        public DeviceTypes DeviceType { get; set; }
        [ForeignKey("ModifiedUserId")]
        [InverseProperty("DevicesModifiedUser")]
        public Users ModifiedUser { get; set; }
        [ForeignKey("OwnerId")]
        [InverseProperty("Devices")]
        public Clients Owner { get; set; }
        [InverseProperty("Device")]
        public ICollection<Repairs> Repairs { get; set; }
    }
}
