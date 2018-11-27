using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool CanLogin { get; set; }
        public bool BuiltIn { get; set; }

        [InverseProperty("Status")]
        public ICollection<Users> Users { get; set; }
    }
}
