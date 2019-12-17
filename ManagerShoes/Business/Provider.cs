using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Tier;
namespace Business
{
    public class Provider
    {
        private ProviderData providerData = new ProviderData();
        public List<eumc1_getAllProviders_Result> GetAllProviders()
        {
            return providerData.GetAllProviders();
        }
    }
}
