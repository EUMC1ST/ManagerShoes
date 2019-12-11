using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Tier;
using Data_Tier;
namespace Business
{
    public class Product : ProductEntity
    {
        public List<ProductEntity> GetProduct(int? id,string name)
        {
            var product = ProductData.GetProductByIdOrName(id, name);
            // List<ProductEntity> productObject = product as List<ProductEntity>;
            return product;
        }
    }
}
