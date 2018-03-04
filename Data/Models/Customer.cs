using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Countries Country { get; set; }
    }
}