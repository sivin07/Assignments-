using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment13._3.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQty { get; set; }

        public Product(int _productId, string _productName, double _productPrice, int _productQty)
        {
            ProductId = _productId;
            ProductName = _productName;
            ProductPrice = _productPrice;
            ProductQty = _productQty;
        }

      
    }
}
