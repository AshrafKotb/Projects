using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Model
{
    public class RoleUservm
    {
        [Required,Display(Name ="User")]
        public string userid { get; set; }
        [Required, Display(Name = "Role")]

        public string roleid { get; set; }

    }
}
