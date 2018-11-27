using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class BaseDeviceStatus
    {
        public BaseDeviceStatus()
        {
            DeviceStatus = new HashSet<DeviceStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("BaseDeviceStatus")]
        public ICollection<DeviceStatus> DeviceStatus { get; set; }
    }
}
