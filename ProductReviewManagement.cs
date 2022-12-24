﻿using System;
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
        public static void FetchDataBasedOnProductIdAndRating(List<ProductReview> list) //UC3
        {
            Console.WriteLine("\n Fetch Data Based On ProductId And Rating");
            List<ProductReview> res = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9)).ToList();
            Program.DisplayProducts(res);
        }
        public static void CountProductIdUsingGroupBy(List<ProductReview> list)     //UC4
        {
            Console.WriteLine("\n Count ProductId Using GroupBy ");
            var res = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var obj in res)
            {
                Console.WriteLine($"ProductID:{obj.Id} Count:{obj.count}");
            }
        }
        public static void GetProductIdAndReview(List<ProductReview> list)      //UC5
        {
            Console.WriteLine("\n Get ProductId And Review ");
            var res = list.Select(p => new { Id = p.ProductId, review = p.Review }).ToList();
            foreach (var obj in res)
            {
                Console.WriteLine($"ProductID:{obj.Id} Review:{obj.review}");
            }
        }
    }
}
