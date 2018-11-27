using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class SettingGroups
    {
        public SettingGroups()
        {
            Settings = new HashSet<Settings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("SettingGroup")]
        public ICollection<Settings> Settings { get; set; }
    }
}
