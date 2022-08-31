using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.DbModel
{
    public class ApplicationUser:IdentityUser
    {
        [Column(TypeName ="nvarchar(150)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Lastname { get; set; }

        public int? BaseId { get; set; }

        public virtual BaseCard Base { get; set; }

    }
}
 