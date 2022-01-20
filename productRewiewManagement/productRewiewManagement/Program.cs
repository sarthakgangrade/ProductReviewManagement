// See https://aka.ms/new-console-template for more information
using productRewiewManagement;

Console.WriteLine("Product Review Management System");
List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() { ProductID = 1, UserID = 22, Rating = 10, Review = "EXCELLENT",isLike= true },
            new ProductReview() { ProductID = 2, UserID = 23, Rating = 9, Review = "EXCELLENT" ,isLike= false},
            new ProductReview() { ProductID = 3, UserID = 24, Rating = 7.2, Review = "GOOD",isLike= true },
            new ProductReview() { ProductID = 4, UserID = 25, Rating = 7.7, Review = "GOOD" ,isLike= false},
            new ProductReview() { ProductID = 5, UserID = 26, Rating = 7.5, Review = "GOOD" ,isLike= false},
            new ProductReview() { ProductID = 6, UserID = 27, Rating = 7, Review = "GOOD" ,isLike= false},
            new ProductReview() { ProductID = 7, UserID = 28, Rating = 6.8, Review = "AVERAGE" ,isLike= true},
            new ProductReview() { ProductID = 8, UserID = 29, Rating = 6.5, Review = "AVERAGE" ,isLike= true},
            new ProductReview() { ProductID = 8, UserID = 30, Rating = 6, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 10, UserID = 31, Rating = 5.5, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 11, UserID = 32, Rating = 5, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 12, UserID = 33, Rating = 4, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 13, UserID = 34, Rating = 3, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 14, UserID = 35, Rating = 2, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 15, UserID = 36, Rating = 7.5, Review = "GOOD" ,isLike= true},
            new ProductReview() { ProductID = 16, UserID = 37, Rating = 7, Review = "GOOD" ,isLike= false},
            new ProductReview() { ProductID = 17, UserID = 38, Rating = 6.8, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 18, UserID = 39, Rating = 6.5, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 19, UserID = 40, Rating = 6, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 20, UserID = 41, Rating = 5.5, Review = "AVERAGE" ,isLike= false},
            new ProductReview() { ProductID = 21, UserID = 42, Rating = 5, Review = "BAD" ,isLike= true},
            new ProductReview() { ProductID = 22, UserID = 43, Rating = 4, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 25, UserID = 44, Rating = 3, Review = "BAD" ,isLike= true},
            new ProductReview() { ProductID = 25, UserID = 45, Rating = 2, Review = "BAD" ,isLike= false},
            new ProductReview() { ProductID = 25, UserID = 46, Rating = 7.5, Review = "GOOD" ,isLike= true},
};
/*foreach (var result in list)
{
    Console.WriteLine("PRODUCT_ID-" + result.ProductID + "  " + "USER_ID-" + result.UserID + "  " + "RATING-" + result.Rating + "  " + "REVIEW-" + result.Review);
}*/

Management management = new Management();
//management.TopRecords(list);
//management.Retrive(list);
//management.Count(list);
//management.RetrieveProductIDAndReview(list);
//management.Skip(list);
management.CreateDataTable(list);
management.Islike_true(list);