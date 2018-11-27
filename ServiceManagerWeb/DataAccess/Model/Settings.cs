using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class Settings
    {
        public int Id { get; set; }
        public int? SettingGroupId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Symbol { get; set; }

        [ForeignKey("SettingGroupId")]
        [InverseProperty("Settings")]
        public SettingGroups SettingGroup { get; set; }
    }
}
