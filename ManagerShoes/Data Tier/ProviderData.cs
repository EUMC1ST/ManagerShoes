using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Tier;
using Data_Tier;
using Entity_Tier;
namespace Data_Tier
{
    public class ProviderData
    {

        private DataProductsEntities _context = new DataProductsEntities();
        
        public List<ProviderEntity> GetAllProviders()
        {
            var productObject = _context.eumc1_getAllProviders().ToList();
            return Assist.Convert<List<eumc1_getAllProviders_Result>, List<ProviderEntity>>(productObject);
        }
    }
}
