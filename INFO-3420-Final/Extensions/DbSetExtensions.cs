using INFO_3420_Final.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INFO_3420_Final
{
    public static class DbSetExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this DbSet<Partner> dbSet)
        {
            return dbSet
                .Select(p => new { p.Name, Id = p.PartnerId })
                .OrderBy(p => p.Name)
                .ToList()
                .Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.Id.ToString()
                });
        }
    }
}