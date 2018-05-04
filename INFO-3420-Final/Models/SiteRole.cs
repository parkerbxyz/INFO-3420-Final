﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class SiteRole
    {
        public int SiteRoleId { get; set; }

        [Display(Name = "Role Name")]
        [StringLength(100, MinimumLength = 2)]
        public string SiteRoleName { get; set; }
    }
}