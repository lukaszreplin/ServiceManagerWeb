using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class DeviceTypes
    {
        public DeviceTypes()
        {
            Devices = new HashSet<Devices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("DeviceType")]
        public ICollection<Devices> Devices { get; set; }
    }
}
