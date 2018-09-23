using System;
using System.Collections.Generic;

namespace RestauantAPP.Model
{
    public class RestauantTypeData
    {
        public static IEnumerable<RestauantType> Get()
        {
            return new List<RestauantType>()
            {
                new RestauantType() {TypeTitle  = "Australian"},
                 new RestauantType() {TypeTitle  = "Chinese"},
                 new RestauantType() {TypeTitle  = "Italy"},
                 new RestauantType() {TypeTitle  = "Japanese"},
                 new RestauantType() {TypeTitle  = "Korean"},
                 new RestauantType() {TypeTitle  = "Mexico"}

            };
        }
    }
}
