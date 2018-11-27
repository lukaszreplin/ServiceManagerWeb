using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class DeviceStatus
    {
        public DeviceStatus()
        {
            Devices = new HashSet<Devices>();
        }

        public int Id { get; set; }
        public int BaseDeviceStatusId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        [ForeignKey("BaseDeviceStatusId")]
        [InverseProperty("DeviceStatus")]
        public BaseDeviceStatus BaseDeviceStatus { get; set; }
        [InverseProperty("DeviceStatus")]
        public ICollection<Devices> Devices { get; set; }
    }
}
