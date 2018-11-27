using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairStatus
    {
        public RepairStatus()
        {
            Repairs = new HashSet<Repairs>();
        }

        public int Id { get; set; }
        public int BaseRepairStatusId { get; set; }
        public string Name { get; set; }
        public string BackgroundColor { get; set; }

        [ForeignKey("BaseRepairStatusId")]
        [InverseProperty("RepairStatus")]
        public BaseRepairStatus BaseRepairStatus { get; set; }
        [InverseProperty("RepairStatus")]
        public ICollection<Repairs> Repairs { get; set; }
    }
}
