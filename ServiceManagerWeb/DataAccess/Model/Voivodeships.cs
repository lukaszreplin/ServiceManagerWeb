using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Voivodeships
    {
        public Voivodeships()
        {
            Clients = new HashSet<Clients>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("Voivodeship")]
        public ICollection<Clients> Clients { get; set; }
    }
}
