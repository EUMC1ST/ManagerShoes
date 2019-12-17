using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Tier;
using Data_Tier;
namespace Business
{
    public class Product 
    {
        private ProductData productData = new ProductData();
        public List<ProductEntity> GetProduct(int? id,string name)
        {
            var product = productData.GetProductByIdOrName(id, name);
            return product;
        }

        public Int32 EditarProducto(ProductEntity product)
        {
            var wasEdited = productData.EditProduct( product);
            return wasEdited;
        }

        public List<CatColors> GetProductColors()
        {
            return productData.GetProductColors();
        }

        public int DeleteProduct(int id)
        {
            var wasDeleted = productData.DeleteProduct(id);
            return wasDeleted;
        }
    }
}
