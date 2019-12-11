using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Tier
{
    public class ProductEntity
    {
        public int Id { get; set;}
        public string Title { get; set; }
        public decimal PriceClient { get; set; }
        public int? IdBrand { get; set; }
        public int? IdCatalog { get; set; }
        public int? IdProvider { get; set; }
    }
}
