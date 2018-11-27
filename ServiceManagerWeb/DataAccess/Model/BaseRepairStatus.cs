using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class BaseRepairStatus
    {
        public BaseRepairStatus()
        {
            RepairStatus = new HashSet<RepairStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("BaseRepairStatus")]
        public ICollection<RepairStatus> RepairStatus { get; set; }
    }
}
