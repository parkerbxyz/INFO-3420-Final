using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class Donation
    {
        public int DonationId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; } = DateTime.Now;

        [Range(0.00, 9999.99)]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
    }
}