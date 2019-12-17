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
        private DataProductsEntities _context = new DataProductsEntities();
        public List<ProductEntity> GetProductByIdOrName (int? id, string name)
        {
            
                var productObject = _context.eumc1_getProductByIdOrName(id, name).ToList();
                return Assist.Convert<List<eumc1_getProductByIdOrName_Result>, List<ProductEntity>>(productObject); //productObject.ToList<eumc1_getProductByIdOrName_Result>();
        }

        public Int32 EditProduct(ProductEntity product)
        {
                var isProductEdited = _context.eumc1_editProduct(
                    product.Id,
                    product.IdType,
                    product.IdColor,
                    product.IdBrand,
                    product.IdProvider,
                    product.IdCatalog,
                    product.Nombre,
                    product.Title,
                    product.Description,
                    product.Observations,
                    product.PriceDistributor,
                    product.PriceClient,
                    product.PriceMember,
                    product.IsEnabled,
                    product.Keywords,
                    product.DateUpdate
                    );
                return isProductEdited;
        }

        public int DeleteProduct(int productId)
        {
                var isProductDeleted = _context.eumc1_deleteProductById(productId);
                return isProductDeleted;
        }


        public List<CatColors> GetProductColors()
        {
            var productColor = _context.eumc1_getProductColors().ToList();
            return Assist.Convert<List<eumc1_getProductColors_Result>,List<CatColors>>(productColor);
        }

        public int CreateProduct(Product product)
        {

            return 1;
        }

    }
}
