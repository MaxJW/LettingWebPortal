﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LWCustomer.Models
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "PCM")]
        public int Price { get; set; }
    }
}
