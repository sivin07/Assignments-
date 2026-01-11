using assignment13._3.Model;
using System;

namespace assignment13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // Taking input for 10 products
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nEnter details for Product {i}");

                Console.Write("Product Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                // Create object using parameterized constructor
                Product objProduct = new Product(id, name, price, qty);
                products.Add(objProduct);
            }

            // Writing data to  file
            using (StreamWriter writer = new StreamWriter("product.csv"))
            {
                foreach (Product objProduct in products)
                {
                    writer.WriteLine($"{objProduct.ProductId},{objProduct.ProductName},{objProduct.ProductPrice},{objProduct.ProductQty}");
                }
            }

            Console.WriteLine("\nProduct details saved to product.csv successfully.");
        }
    }
}