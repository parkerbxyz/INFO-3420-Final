﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class Donation
    {
        public int DonationId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; }

        [Range(0.00, 9999.99)]
        public decimal Amount { get; set; }
    }
}