using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Homework
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }

        public Product(decimal price, string name, int quantity)
        {
            Price = price;
            Name = name;
            Quantity = quantity;           
        }

        public decimal CalculateTotalValue()
        {
            return Price * Quantity;
        }
    }
}
