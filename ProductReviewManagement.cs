using System;
using System.Collections.Generic;
using System.Data;
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
        public static void GetProductIdAndReview(List<ProductReview> list)      //UC5 and UC7 are Same
        {
            Console.WriteLine("\n Get ProductId And Review ");
            //var data = list.Select(p => (p.ProductId, p.Review));
            var res = list.Select(p => new { Id = p.ProductId, review = p.Review }).ToList();
            foreach (var obj in res)
            {
                Console.WriteLine($"ProductID:{obj.Id} Review:{obj.review}");
            }
        }
        public static void Skip5Records(List<ProductReview> list)       //UC6
        {
            Console.WriteLine("\n Skip5Records Display remaining product reviews");
            var res = list.Skip(5).ToList();
            Program.DisplayProducts(res);
        }
        public static DataTable AddDataTable()      //UC8 Create DataTable and Add 25 default Values . 
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("UserID", typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(bool));

            table.Rows.Add(101, 1, 4, "Good", true);
            table.Rows.Add(102, 2, 5, "Excellent", true);
            table.Rows.Add(103, 3, 4.5, "Good", true);
            table.Rows.Add(104, 4, 3.5, "Good", true);
            table.Rows.Add(105, 5, 2, "Worst", false);
            table.Rows.Add(105, 6, 1, "Worst", false);
            table.Rows.Add(103, 7, 1, "Worst", false);
            table.Rows.Add(104, 8, 2.5, "Average", false);
            table.Rows.Add(101, 9, 1.5, "Worst", false);
            table.Rows.Add(102, 10, 3.5, "Average", true);
            table.Rows.Add(105, 11, 5, "Good", true);
            table.Rows.Add(103, 12, 4.5, "Good", true);
            table.Rows.Add(104, 13, 3, "Average", true);
            table.Rows.Add(102, 14, 3, "Good", true);
            table.Rows.Add(103, 15, 1, "Worst", false);
            table.Rows.Add(102, 16, 2, "Average", false);
            table.Rows.Add(105, 17, 2.5, "Average", false);
            table.Rows.Add(103, 18, 5, "Good", true);
            table.Rows.Add(105, 19, 4, "Good", true);
            table.Rows.Add(103, 20, 4, "Good", true);
            table.Rows.Add(102, 21, 4, "Good", true);
            table.Rows.Add(102, 22, 5, "Good", true);
            table.Rows.Add(102, 23, 5, "Good", true);
            table.Rows.Add(104, 24, 2, "Average", false);
            table.Rows.Add(103, 25, 3, "Average", false);
            return table;
        }
        public static void DisplayDataTableRecords(DataTable table)
        {
            var records = from datas in table.AsEnumerable() select datas; 
            foreach (var items in records)
            {
                Console.WriteLine("UserID:" + items.Field<int>("UserID")+"\tProductID:" + items.Field<int>("ProductID") +
                    "\tRating:" + items.Field<double>("Rating") + "\tReview:" + items.Field<string>("Review") + "\tIsLike:" + items.Field<bool>("isLike"));
            }
        }
    }
}
