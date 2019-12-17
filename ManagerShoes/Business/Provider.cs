using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Tier;
using Entity_Tier;
namespace Business
{
    public class Provider
    {
        private ProviderData providerData = new ProviderData();
        public List<ProviderEntity> GetAllProviders()
        {
            return providerData.GetAllProviders();
        }
    }
}
