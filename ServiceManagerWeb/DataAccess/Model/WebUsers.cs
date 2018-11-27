using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class WebUsers
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        [InverseProperty("WebUsers")]
        public Clients Client { get; set; }
    }
}
