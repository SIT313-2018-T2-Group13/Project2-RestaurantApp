using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestauantAPP.Model
{
    public class CNData 
    {
        public static IEnumerable<CN> Get()
        {
            return new List<CN>()
            {

            new CN {  ResName = "Dragon Boat Restaurant", Address = "201 Little Bourke St, Melbourne VIC 3000", PNumber = "(03) 9662 2733", OHours = "8:00am-23:00:pm Mon-Sunday", Price = "$15-$30" },
            new CN {  ResName = "China Red", Address = "206 Bourke St, Melbourne VIC 3000", PNumber = "(03) 9662 3688", OHours = "11:30am-22:30:pm Mon-Sunday", Price = "$20-$70" },
            new CN {  ResName = "Bamboo House", Address = "47 Little Bourke St, Melbourne VIC 3000", PNumber = "(03) 9662 1565", OHours = "12:00pm-23:00:pm Mon-Fir", Price = "$10-$50" },
            new CN {  ResName = "Dainty Sichuan Food", Address = "176 Toorak Rd, South Yarra VIC 3141", PNumber = "(03) 9078 1686", OHours = "11:30am-22:00:pm Mon-Fir", Price = "$50-$100" }

            };
        }
    }
}

