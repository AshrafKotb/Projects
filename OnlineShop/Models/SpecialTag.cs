using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class SpecialTag
    {
        public int id { get; set; }
        [Required, Display(Name ="Special Tag")]
        public string name { get; set; }
    }
}
