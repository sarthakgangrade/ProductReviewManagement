using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productRewiewManagement
{
    internal class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> productlist)
        {
            var record = (from ProductReview in productlist orderby ProductReview.Rating descending
                          select ProductReview).Take(3);
            foreach (var r in record)
            {
                Console.WriteLine("PRODUCT_ID-" + r.ProductID + "  " + "USER_ID-" + r.UserID + "  " + "RATING-" + r.Rating + "  " + "REVIEW-" + r.Review);
            }
        }
        public void Retrive(List<ProductReview> productlist)
        {
            var record = (from ProductReview in productlist
                          where ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9
                          && ProductReview.Rating > 3
                          select ProductReview);
            foreach (var r in record)
            {
                Console.WriteLine("PRODUCT_ID-" + r.ProductID + "  " + "USER_ID-" + r.UserID + "  " + "RATING-" + r.Rating + "  " + "REVIEW-" + r.Review);
            }
        }

        public void Count(List<ProductReview> productReviews)
        {
            var record = from product in productReviews
                         group product by product.ProductID into g
                         select new { ProductID = g.Key, ProductCount = g.Count() };
            foreach (var r in record)
            {
                Console.WriteLine("Productid" + r.ProductID + "count" + r.ProductCount);
            }

        }


    }
}
