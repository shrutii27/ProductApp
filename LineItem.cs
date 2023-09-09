using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }
        public int Product1 { get; set; }
        public int Product2 { get; set; }
        public double Price { get; set; }
        public LineItem(int product1, int product2, double price)
        {
           Product1 = product1;
           Product2 = product2;
           Price = price;
        }

        public double CalculateLineItemCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }
    }
}

