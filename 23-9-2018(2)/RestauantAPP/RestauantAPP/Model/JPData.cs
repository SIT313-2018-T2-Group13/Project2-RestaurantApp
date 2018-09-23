using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestauantAPP.Model
{
    public class JPData 
    {
        public static IEnumerable<JP> Get()
        {
            return new List<JP>()
            {

                 new JP {  ResName = "Japanese Teppanyaki Inn", Address = "182 Collins St, Melbourne VIC 3000", PNumber = "(03) 9650 9432", OHours = "12:00pm-22:00pm Mon-Fir", Price = "$15-$55" },
            new JP {  ResName = "Yamato Japanese Restaurant", Address = "28 Corrs Ln, Melbourne VIC 3000", PNumber = "(03) 9663 1706", OHours = "11:00am-22:30pm Mon-Fir", Price = "$25-$75" },
            new JP {  ResName = "Rice Workshop", Address = "238 Little Bourke St, Melbourne VIC 3000", PNumber = "(03) 9650 6663", OHours = "11:00am-22:00pm Mon- Sunday", Price = "$30-$60" },
            new JP {  ResName = "Wagaya Melbourne", Address = "Mid City, 201/200 Bourke St, Melbourne VIC 3000", PNumber = "(03) 9663 7756", OHours = "11:00am-22:00pm Mon- Sunday", Price = "$20-$60"}

            };
        }
    }
}

