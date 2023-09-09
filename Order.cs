using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Order
    {
        public int OrderNumber { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> LineItems { get; set; }

        public Order(int orderNumber, int id, DateTime date, List<LineItem> lineItems)
        {
            OrderNumber = orderNumber;
            Id = id;
            Date = date;
            LineItems = lineItems;
        }
        public double CalculateOrderPrice()
        {
            double totalOrderPrice = 0;
            foreach (LineItem lineItem in LineItems)
            {
                totalOrderPrice += lineItem.CalculateLineItemCost();
            }
            return totalOrderPrice;
        }
    }
}
