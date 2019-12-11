using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common_Tier
{
    public static class Assist
    {
        public static Out Convert<In, Out>(In Object)
        {
            string output = JsonConvert.SerializeObject(Object);
            return JsonConvert.DeserializeObject<Out>(output);
        }
    }
}
