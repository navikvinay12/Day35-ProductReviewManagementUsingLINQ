using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo222Batch
{
    public class ProductReviewManagement
    {
        public static void RetrieveTop3BasedOnRating(List<ProductReview> list)  //UC2
        {
            Console.WriteLine("\n Retrieve Top3 Records Based on Rating");
            var top3Records = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProducts(top3Records);

            //Console.WriteLine("\n Using query syntax");
            //var res = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            //Program.DisplayProducts(res);
        }
    }
}
