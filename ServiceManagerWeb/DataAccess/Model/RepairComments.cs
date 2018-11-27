using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairComments
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? RepairId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey("RepairId")]
        [InverseProperty("RepairComments")]
        public Repairs Repair { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("RepairComments")]
        public Users User { get; set; }
    }
}
