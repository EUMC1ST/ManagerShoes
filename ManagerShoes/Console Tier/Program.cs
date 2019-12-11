using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Entity_Tier;

namespace Console_Tier
{
    class Program
    {
        static void Main(string[] args)
        {
            var busiObj = new Product();
            foreach (var item in busiObj.GetProduct(3, ""))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
