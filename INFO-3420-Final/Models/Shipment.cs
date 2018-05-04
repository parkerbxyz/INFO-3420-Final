using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Label Date")]
        public DateTime LabelDate { get; set; } = DateTime.Now;

        [Display(Name = "Tracking Number")]
        public string TrackingNumber { get; set; }

        [Display(Name = "Shoe Size")]
        public int ShoeSize { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }
    }
}