using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class RepairTypes
    {
        public RepairTypes()
        {
            Repairs = new HashSet<Repairs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("RepairType")]
        public ICollection<Repairs> Repairs { get; set; }
    }
}
