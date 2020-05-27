using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LettingWeb.Models
{
    public class Property
    {
        public int Id { get; set; }
        [Display(Name = "Location")]
        public string Address { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
