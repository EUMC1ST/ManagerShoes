using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Tier;
using Entity_Tier;

namespace Data_Tier
{
    public class ProductData
    {

        public static List<ProductEntity> GetProductByIdOrName (int? id, string name)
        {
            using (var context = new DataProductsEntities())
            {
                var productObject = context.eumc1_getProductByIdOrName(id, name).ToList();
                
                return Assist.Convert<List<eumc1_getProductByIdOrName_Result>, List<ProductEntity>>(productObject); //productObject.ToList<eumc1_getProductByIdOrName_Result>();
            }

        }
    }
}
