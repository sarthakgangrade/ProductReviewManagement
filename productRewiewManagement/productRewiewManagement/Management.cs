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
        public DataTable datatable = new DataTable();
        public void TopRecords(List<ProductReview> productlist)
        {
            var record = (from ProductReview in productlist
                          orderby ProductReview.Rating descending
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

        public void RetrieveProductIDAndReview(List<ProductReview> list)
        {

            var p = from product in list
                    select new { product.ProductID, product.Review };
            foreach (var element in p)
            {
                Console.WriteLine("ProductId : " + element.ProductID + "    Review : " + element.Review);

            }
        }

        public void Skip(List<ProductReview> list)
        {

            var p = (from product in list
                     select product).Skip(5);
            foreach (var element in p)
            {
                Console.WriteLine("PRODUCT_ID-" + element.ProductID + "  " + "USER_ID-" + element.UserID + "  " + "RATING-" + element.Rating + "  " + "REVIEW-" + element.Review);

            }
        }
        DataTable dt = new DataTable();
        public void CreateDataTable(List<ProductReview> list)
        {


            dt.Columns.Add("ProductID").DataType = typeof(int);
            dt.Columns.Add("UserID").DataType = typeof(int);
            dt.Columns.Add("Rating").DataType = typeof(double);
            dt.Columns.Add("Review").DataType = typeof(string);
            dt.Columns.Add("isLike").DataType = typeof(bool);
            DataRow Rows = dt.NewRow();
            dt.Rows.Add("75", "44", "10", "Excellent", "true");
            dt.Rows.Add("65", "45", "1", "Poor", "true");
            dt.Rows.Add("55", "46", "7", "Average", "false");
            dt.Rows.Add("45", "47", "10", "Excellent", "true");
            dt.Rows.Add("35", "48", "0", "Poor", "true");
            foreach (ProductReview item in list)
            {
                dt.Rows.Add(item.ProductID, item.UserID, item.Rating, item.Review, item.isLike);
            }
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine("ProductID::" + r["ProductID"] + " " + "UserID::" + r["UserID"] + " " + "Rating::" + r["Rating"] + " " + "Review::" + r["Review"] + " " + "isLike::" + r["isLike"]);

            }

        }
        public void Islike_true(List<ProductReview> list)
        {
            
            var productTable = from products in this.dt.AsEnumerable()
                               where products.Field<bool>("isLike").Equals(true)
                               select products;

            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserId") + " " + product.Field<double>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("isLike"));
            }
        }

        public void AverageRating(List<ProductReview> list)
        {
            var pt = dt.AsEnumerable().Average(e => e.Field<double>("Rating"));
            Console.WriteLine("Rating average::"+pt);
        }
    }
}
