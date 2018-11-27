using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Users
    {
        public Users()
        {
            ClientsAnonimizedUser = new HashSet<Clients>();
            ClientsCreatedUser = new HashSet<Clients>();
            ClientsExportedUser = new HashSet<Clients>();
            ClientsModifiedUser = new HashSet<Clients>();
            DevicesCreatedUser = new HashSet<Devices>();
            DevicesModifiedUser = new HashSet<Devices>();
            RepairActions = new HashSet<RepairActions>();
            RepairComments = new HashSet<RepairComments>();
            Repairs = new HashSet<Repairs>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(40)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(40)]
        public string Lastname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastFailedLoginDate { get; set; }
        public int? NumberOfFailedLogin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPasswordChangeDate { get; set; }
        public int? StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LockDate { get; set; }
        public int? UserGroupId { get; set; }
        public string ApplicationAccent { get; set; }
        public string ApplicationTheme { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("Users")]
        public UserStatus Status { get; set; }
        [ForeignKey("UserGroupId")]
        [InverseProperty("Users")]
        public UserGroups UserGroup { get; set; }
        [InverseProperty("AnonimizedUser")]
        public ICollection<Clients> ClientsAnonimizedUser { get; set; }
        [InverseProperty("CreatedUser")]
        public ICollection<Clients> ClientsCreatedUser { get; set; }
        [InverseProperty("ExportedUser")]
        public ICollection<Clients> ClientsExportedUser { get; set; }
        [InverseProperty("ModifiedUser")]
        public ICollection<Clients> ClientsModifiedUser { get; set; }
        [InverseProperty("CreatedUser")]
        public ICollection<Devices> DevicesCreatedUser { get; set; }
        [InverseProperty("ModifiedUser")]
        public ICollection<Devices> DevicesModifiedUser { get; set; }
        [InverseProperty("ActionUser")]
        public ICollection<RepairActions> RepairActions { get; set; }
        [InverseProperty("User")]
        public ICollection<RepairComments> RepairComments { get; set; }
        [InverseProperty("Technician")]
        public ICollection<Repairs> Repairs { get; set; }
    }
}
