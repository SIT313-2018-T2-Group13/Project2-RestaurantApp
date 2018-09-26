using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestauantAPP.Model
{
    public class KOData 
    {
        public static IEnumerable<KO> Get()
        {
            return new List<KO>()
            {

                 new KO {  ResName = "Ohsso korean street food", Address = "28 Hardware Ln, Melbourne VIC 3000", PNumber = "(03) 9043 1203", OHours = "11:30am-2:00pm Mon- Sunday", Price = "$15-$30" },
            new KO {  ResName = "SUDA, KOREAN EATERY", Address = "C2/550 Lonsdale St, (ON HEALEYS LANE), Melbourne VIC 3000", PNumber = "(03) 9942 6422", OHours = "11:00am-23:00pm Mon- Sunday", Price = "$20-$50" },
            new KO {  ResName = "Oriental Spoon", Address = "254 La Trobe St, Melbourne VIC 3000", PNumber = "(03) 9654 9930", OHours = "12:00pm-22:00pm Mon- Sunday", Price = "$20-$35"},
            new KO {  ResName = "ChangGo Korean BBQ", Address = "70 Little La Trobe St, Melbourne VIC 3000", PNumber = "(03) 9663 7777", OHours = "17:30pm-23:00pm Mon-Sun", Price = "$20-$60" }

            };
        }
    }
}

