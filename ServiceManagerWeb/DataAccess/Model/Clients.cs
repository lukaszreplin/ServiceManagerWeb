using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Clients
    {
        public Clients()
        {
            Devices = new HashSet<Devices>();
            Repairs = new HashSet<Repairs>();
            WebUsers = new HashSet<WebUsers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Column("TIN")]
        public string Tin { get; set; }
        [Column("NBRN")]
        public string Nbrn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string PostCity { get; set; }
        public string City { get; set; }
        public string Community { get; set; }
        public string County { get; set; }
        public int? VoivodeshipId { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "text")]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool? IsAnonimized { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AnonimizedDate { get; set; }
        public int? AnonimizedUserId { get; set; }
        public bool? IsExported { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExportedDate { get; set; }
        public int? ExportedUserId { get; set; }

        [ForeignKey("AnonimizedUserId")]
        [InverseProperty("ClientsAnonimizedUser")]
        public Users AnonimizedUser { get; set; }
        [ForeignKey("CreatedUserId")]
        [InverseProperty("ClientsCreatedUser")]
        public Users CreatedUser { get; set; }
        [ForeignKey("ExportedUserId")]
        [InverseProperty("ClientsExportedUser")]
        public Users ExportedUser { get; set; }
        [ForeignKey("ModifiedUserId")]
        [InverseProperty("ClientsModifiedUser")]
        public Users ModifiedUser { get; set; }
        [ForeignKey("VoivodeshipId")]
        [InverseProperty("Clients")]
        public Voivodeships Voivodeship { get; set; }
        [InverseProperty("Owner")]
        public ICollection<Devices> Devices { get; set; }
        [InverseProperty("Client")]
        public ICollection<Repairs> Repairs { get; set; }
        [InverseProperty("Client")]
        public ICollection<WebUsers> WebUsers { get; set; }
    }
}
