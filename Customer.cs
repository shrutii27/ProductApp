using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, List<Order> orders)
        {
            Id = id;
            Name = name;
            Orders = orders;
        }
    }
}