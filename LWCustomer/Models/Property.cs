using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWCustomer.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
