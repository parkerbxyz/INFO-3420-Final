using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Label Created")]
        public DateTime LabelDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ship By")]
        public DateTime ShipByDate { get; set; }

        [Display(Name = "Tracking Number")]
        public string TrackingNumber { get; set; }

        public string Status { get; set; }
    }
}