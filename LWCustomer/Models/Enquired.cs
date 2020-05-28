using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LWCustomer.Models
{
    public class Enquired
    {
        public int EnquiredId { get; set; }

        [ForeignKey("AspNetUsers")]
        [Required]
        public int UserId { get; set; }

        [ForeignKey("Property")]
        [Required]
        public int PropertyId { get; set; }

        [Required]
        public bool HasEnquired { get; set; }
    }
}
