using ProductApp.Model;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Book", 100, 10);
            Product product2 = new Product(2, "Mobile", 1500, 2);

            //create line items for the first order
            LineItem lineItem1 = new LineItem(1, 2, product1);
            LineItem lineItem2 = new LineItem(2, 3, product2);

            Order order1 = new Order(1, 101, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });

            //create line items for the 2nd order
            LineItem lineItem3 = new LineItem(3, 2, product1);
            LineItem lineItem4 = new LineItem(4, 4, product2);

            Order order2 = new Order(2, 102, DateTime.Now, new List<LineItem> { lineItem3, lineItem4 });

            Customer customer1 = new Customer(1, "ABCD", new List<Order> { order1, order2 });

            Console.WriteLine($"Customer Id: {customer1.Id}\nCustomer Name: {customer1.Name}");

            foreach (Order order in customer1.Orders)
            {
                Console.WriteLine($"Order Number: {order.OrderNumber}");
                Console.WriteLine($"Order ID: {order.Id}");
                Console.WriteLine($"Order Date: {order.Date}");
                Console.WriteLine("--------------------------------------");

                foreach (LineItem lineItem in order.LineItems)
                {
                   Console.WriteLine($"Line Item ID: {lineItem.Id}");
                   Console.WriteLine($"Product ID: {lineItem.Product.Id}");
                   Console.WriteLine($"Product Name: {lineItem.Product.Name}");
                   Console.WriteLine($"Quantity: {lineItem.Quantity}");
                   Console.WriteLine($"Unit Price: {lineItem.Product.Price}");
                   Console.WriteLine($"Discount Percentage: {lineItem.Product.DiscountPercent}%");
                   Console.WriteLine($"Unit Cost After Discount: {lineItem.Product.CalculateDiscountedPrice()}");
                   Console.WriteLine($"Total Line Item Cost: {lineItem.CalculateLineItemCost()}");
                   Console.WriteLine();
                }
                Console.WriteLine($"Total Order Cost: {order.CalculateOrderPrice()}");
                Console.WriteLine();
            }
        }
    }
}


