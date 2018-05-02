using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INFO_3420_Final.Models
{
    public class ApplicationDbContextInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Locations.Add(new Location
            {
                Partner = new Partner { Name = "Deseret Industries" },
                Address = "123 Sesame St."
            });

            base.Seed(context);
        }
    }
}