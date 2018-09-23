using System;
using System.Collections.Generic;

namespace RestauantAPP.Model
{
    public class AUData
    {
        public static IEnumerable<AU> Get()
        {
            return new List<AU>()
            {

                 new AU {  ResName = "The Mill", Address = "71 Hardware Ln, Melbourne VIC 3000", PNumber = "(03) 9600 1454", OHours = "12:00pm-23:pm Mon-Fri", Price = "$20-$50" },
            new AU {  ResName = "EZARD", Address = "187 Flinders Ln, Melbourne VIC 3000", PNumber = "(03) 9639 6811", OHours = "12:00pm-22:30:pm Mon-Fri", Price = "$30-$70" },
            new AU {  ResName = "Rare Steakhouse Midtown", Address = "12 Goldie Pl, Melbourne VIC 3000", PNumber = "(03) 9670 7317", OHours = "12:00pm-22:00:pm Mon-Fri", Price = "$10-$40" },
            new AU {  ResName = "Burma Lane", Address = "118 Little Collins St, Melbourne VIC 3000", PNumber = "(03) 9615 8500", OHours = "12:00pm-22:00pm Mon-Fri", Price = "$20-$40" }

            };
        }
    }
}
