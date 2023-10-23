namespace Product_Inventory_Homework;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

       
        List<Product> productList = new List<Product>
            {
                new Product(41300,"Sony", 26),
                new Product(34600,"LG", 15),
                new Product(23500,"Dexp", 44)
            };

        
        foreach (var product in productList)
        {
            inventory.AddProduct(product);
        }

        inventory.PrintInventory();

        decimal totalValue = inventory.CalculateInventoryValue();

        Console.WriteLine($"Общая стоимость инвентаря: {totalValue}");

        Console.ReadLine();
    }
}