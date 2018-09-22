using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestauantAPP.Model
{
    public class ITData 
    {
        public static IEnumerable<IT> Get()
        {
            return new List<IT>()
            {

                 new IT {  ResName = "Il Bacaro", Address = "168-170 Little Collins St, Melbourne VIC 3000", PNumber = "(03) 9654 6778", OHours = "12:00pm-22:30pm Mon- Saturday", Price = "$20-$70" },
            new IT {  ResName = "Maccaroni Trattoria Italiana", Address = "10 Manchester Ln, Melbourne VIC 3000", PNumber = "(03) 9090 7634", OHours = "10:00am-22:00pm Mon- Sunday", Price = "$20-$80" },
            new IT {   ResName = "Universal Restaurant", Address = "139-141 Lygon St, Carlton VIC 3053", PNumber = "(03) 9347 4393", OHours = "11:00am-23:00pm Mon- Sunday", Price = "$20-$50" },
            new IT {   ResName = "Grossi Florentino", Address = "80 Bourke St, Melbourne VIC 3000", PNumber = "(03) 9662 1811", OHours = "7:00am-00:00pm Mon- Saturday", Price = "$20-$60"}

            };
        }
    }
}

