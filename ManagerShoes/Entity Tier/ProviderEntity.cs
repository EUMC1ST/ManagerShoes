using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Tier
{
    public class ProviderEntity
    {
        public int IdProvider { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public string Url { get; set; }
    }
}
