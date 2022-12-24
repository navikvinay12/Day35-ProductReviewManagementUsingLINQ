namespace LINQDemo222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()        //UC1
            {
                new ProductReview() { ProductId = 3, UserId = 1, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 1, UserId = 2, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 4, UserId = 3, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 2, UserId = 4, IsLike = true, Review = "nice", Rating = 90 },
                new ProductReview() { ProductId = 5, UserId = 5, IsLike = false, Review = "bad", Rating = 30 },
                new ProductReview() { ProductId = 10, UserId = 6, IsLike = false, Review = "bad", Rating = 31 },
                new ProductReview() { ProductId = 5, UserId = 7, IsLike = false, Review = "bad", Rating = 32 },
                new ProductReview() { ProductId = 3, UserId = 8, IsLike = true, Review = "good", Rating = 81 },
                new ProductReview() { ProductId = 9, UserId = 9, IsLike = false, Review = "bad", Rating = 25 },
                new ProductReview() { ProductId = 13, UserId = 10, IsLike = true, Review = "average", Rating = 53 },
                new ProductReview() { ProductId = 20, UserId = 11, IsLike = true, Review = "nice", Rating = 91 },
                new ProductReview() { ProductId = 18, UserId = 12, IsLike = false, Review = "bad", Rating = 33 },
                new ProductReview() { ProductId = 16, UserId = 13, IsLike = false, Review = "bad", Rating = 34 },
                new ProductReview() { ProductId = 19, UserId = 14, IsLike = false, Review = "bad", Rating = 36 },
                new ProductReview() { ProductId = 20, UserId = 15, IsLike = true, Review = "good", Rating = 82 },
                new ProductReview() { ProductId = 11, UserId = 16, IsLike = false, Review = "bad", Rating = 37 },
                new ProductReview() { ProductId = 17, UserId = 17, IsLike = true, Review = "average", Rating = 52 },
                new ProductReview() { ProductId = 23, UserId = 18, IsLike = true, Review = "nice", Rating = 92 },
                new ProductReview() { ProductId = 11, UserId = 19, IsLike = false, Review = "bad", Rating = 38 },
                new ProductReview() { ProductId = 15, UserId = 20, IsLike = false, Review = "bad", Rating = 39 },
                new ProductReview() { ProductId = 19, UserId = 21, IsLike = false, Review = "bad", Rating = 30 },
                new ProductReview() { ProductId = 21, UserId = 22, IsLike = true, Review = "good", Rating = 83 },
                new ProductReview() { ProductId = 15, UserId = 23, IsLike = false, Review = "bad", Rating = 35 },
                new ProductReview() { ProductId = 13, UserId = 24, IsLike = true, Review = "average", Rating = 51 },
                new ProductReview() { ProductId = 22, UserId = 25, IsLike = true, Review = "nice", Rating = 93 }
            };
            DisplayProducts(list);
            ProductReviewManagement.RetrieveTop3BasedOnRating(list);        //UC2
            ProductReviewManagement.FetchDataBasedOnProductIdAndRating(list);   //UC3
        }
        public static void DisplayProducts(List<ProductReview> list)
        {
            foreach(ProductReview product in list)
            {
                Console.WriteLine(product);
            }
        }
    }
}