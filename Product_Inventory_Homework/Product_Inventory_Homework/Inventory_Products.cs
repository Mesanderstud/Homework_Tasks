using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Homework
{
    public class Inventory
    {
        private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);

        }
        public void PrintInventory()
        {
            Console.WriteLine("Inventory:");

            foreach (var product in products)
            {
                Console.WriteLine($" Price: {product.Price} | Product: {product.Name} | Quantity: {product.Quantity}");
            }
        }

        public decimal CalculateInventoryValue()
        {
            decimal totalValue = 0;

            foreach (var product in products)
            {
                totalValue += product.CalculateTotalValue();
            }

            return totalValue;
        }
    }
}
