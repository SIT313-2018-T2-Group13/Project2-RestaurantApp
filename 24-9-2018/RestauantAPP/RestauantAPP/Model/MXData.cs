using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestauantAPP.Model
{
    public class MXData 
    {
        public static IEnumerable<MX> Get()
        {
            return new List<MX>()
            {

                 new MX {  ResName = "El Sabor by El Cielo", Address = "500 Victoria St, North Melbourne VIC 3051", PNumber = "(03) 9329 9477", OHours = "11:00am-14:30pm Mon-Fir", Price = "$35-$50" },
            new MX {   ResName = "Hello José", Address = "85 Peel St, West Melbourne VIC 3003", PNumber = "(03) 9326 3934", OHours = "17:00pm-23:00pm Mon- Sunday", Price = "$15-$40" },
            new MX {  ResName = "Fonda Mexican", Address = "31 Flinders Ln, Melbourne VIC 3000", PNumber = "(03) 8686 7300", OHours = "11:30am-22:30pm Mon- Sunday", Price = "$20-$60"},
            new MX {   ResName = "Touche Hombre", Address = "233 Lonsdale St, Melbourne VIC 3000", PNumber = "(03) 9663 0811", OHours = "12:00pm-22:00pm Mon- Saturday", Price = "$20-$650" }

            };
        }
    }
}

