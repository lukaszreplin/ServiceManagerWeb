using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManager.DataAccess.Model
{
    public partial class EmailTemplates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
