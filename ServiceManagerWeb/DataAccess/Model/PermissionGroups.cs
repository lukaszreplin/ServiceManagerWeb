using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class PermissionGroups
    {
        public PermissionGroups()
        {
            UserGroups = new HashSet<UserGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool CanViewDevices { get; set; }
        public bool CanAddDevice { get; set; }
        public bool CanEditDevice { get; set; }
        public bool CanDeleteDevice { get; set; }
        public bool CanViewClients { get; set; }
        public bool CanAddClient { get; set; }
        public bool CanEditClient { get; set; }
        public bool CanDeleteClient { get; set; }
        public bool CanSupport { get; set; }
        public bool CanChangeAppStyle { get; set; }
        public bool CanManageReports { get; set; }
        public bool CanViewReports { get; set; }
        public bool CanViewWarehouse { get; set; }
        public bool CanManageWarehouse { get; set; }
        public bool CanManageUsers { get; set; }
        public bool CanManageUserGroups { get; set; }
        public bool CanManagePermissionGroups { get; set; }
        public bool CanManageNotificationTemplates { get; set; }
        public bool CanManagePrinters { get; set; }
        public bool CanViewRepair { get; set; }
        public bool CanAddRepair { get; set; }
        public bool CanEditRepair { get; set; }
        public bool CanDeleteRepair { get; set; }
        public bool CanAnonymizeClient { get; set; }

        [InverseProperty("PermissionGroup")]
        public ICollection<UserGroups> UserGroups { get; set; }
    }
}
