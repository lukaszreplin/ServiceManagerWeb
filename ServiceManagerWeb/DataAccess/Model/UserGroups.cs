using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? PermissionGroupId { get; set; }

        [ForeignKey("PermissionGroupId")]
        [InverseProperty("UserGroups")]
        public PermissionGroups PermissionGroup { get; set; }
        [InverseProperty("UserGroup")]
        public ICollection<Users> Users { get; set; }
    }
}
