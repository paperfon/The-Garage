﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Garage.Models
{
    public class MemberDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Number of Vehicles")]
        public int NumberOfVehicles { get; set; }
        public IEnumerable<Vehicles> TheVehicles { get; set; }
    }
}
