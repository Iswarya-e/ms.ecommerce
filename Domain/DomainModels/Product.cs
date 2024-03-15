
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Xml.Linq;

namespace Domain.Models
{
    public class Product
    {
        public Product() { }
        public Product(int productId, string productName, int productPrice, string productDetails, string productImage)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductDetails = productDetails;
            ProductImage = productImage;
        }


        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; } 
        public string ProductDetails { get; set; } 
        public string ProductImage { get; set; }

    }
}
