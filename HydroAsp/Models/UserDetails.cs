using HydroAsp.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HydroAsp.Models
{
    public class UserDetails
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
    }
}