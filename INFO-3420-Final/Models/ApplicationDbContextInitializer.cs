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
            context.Partners.Add(new Partner { Name = "Deseret Industries",
                Locations = new List<Location>
                {
                    new Location { Address = "825 E 9400 S", City = "Sandy", State = "UT", Zip = "84094" },
                    new Location { Address = "11 E 4500 S", City = "Murray", State = "UT", Zip = "84107" },
                    new Location { Address = "7166 S Redwood Rd", City = "West Jordan", State = "UT", Zip = "84084" },
                    new Location { Address = "2140 S 800 E", City = "Salt Lake City", State = "UT", Zip = "84106" },
                    new Location { Address = "12449 Creek Meadow Rd", City = "Riverton", State = "UT", Zip = "84065" },
                    new Location { Address = "1665 South Bennett Road", City = "Salt Lake City", State = "UT", Zip = "84104" },
                    new Location { Address = "2994 S Glen Eagle Dr Suite A", City = "West Valley City", State = "UT", Zip = "84128" },
                    new Location { Address = "435 S 500 E", City = "American Fork", State = "UT", Zip = "84003" },
                    new Location { Address = "743 W 700 S", City = "Salt Lake City", State = "UT", Zip = "84104" },
                    new Location { Address = "158 E Pages Ln", City = "Centerville", State = "UT", Zip = "84014" },
                    new Location { Address = "1415 N State St", City = "Provo", State = "UT", Zip = "84604" },
                    new Location { Address = "930 W Hill Field Rd", City = "Layton", State = "UT", Zip = "84041" },
                    new Location { Address = "1575 N 30 W", City = "Tooele", State = "UT", Zip = "84074" },
                    new Location { Address = "645 S 1750 W", City = "Springville", State = "UT", Zip = "84663" }
                }
            });

            context.Partners.Add(new Partner
            {
                Name = "Big Brothers Big Sisters of Utah",
                Locations = new List<Location>
                {
                    new Location { Address = "2121 State St #201", City = "Salt Lake City", State = "UT", Zip = "84115" },
                    new Location { Address = "151 5600 S #200", City = "Murray", State = "UT", Zip = "84107" },
                    new Location { Address = "1875 E Murray Holladay Rd", City = "Holladay", State = "UT", Zip = "84117" },
                    new Location { Address = "1605 W 12600 S", City = "Riverton", State = "UT", Zip = "84065" },
                    new Location { Address = "5532 Lillehammer Ln #202", City = "Park City", State = "UT", Zip = "84098" }
                }
            });

            context.Partners.Add(new Partner
            {
                Name = "Assistance League of Salt Lake",
                Locations = new List<Location>
                {
                    new Location { Address = "2060 S Valley St", City = "Salt Lake City", State = "UT", Zip = "84109" },
                }
            });

            context.Partners.Add(new Partner
            {
                Name = "The Road Home",
                Locations = new List<Location>
                {
                    new Location { Address = "210 S Rio Grande St", City = "Salt Lake City", State = "UT", Zip = "84101" },
                    new Location { Address = "529 9th Ave", City = "Midvale", State = "UT", Zip = "84047" }
                }
            });

            context.Partners.Add(new Partner
            {
                Name = "International Rescue Committee",
                Locations = new List<Location>
                {
                    new Location { Address = "221 South 400 West", City = "Salt Lake City", State = "UT", Zip = "84101" }
                }
            });

            context.Partners.Add(new Partner
            {
                Name = "The Salvation Army",
                Locations = new List<Location>
                {
                    new Location { Address = "438 South 900 West", City = "Salt Lake City", State = "UT", Zip = "84104" }
                }
            });

            base.Seed(context);
        }
    }
}