namespace Assignment_6
{
    internal class Program
    {
        class Product
        {
            public string productName;
            public double price;
            public int stockQuantity;

            // Constructor
            public Product(string productName, double price, int stockQuantity)
            {
                this.productName = productName;
                this.price = price;
                this.stockQuantity = stockQuantity;
            }

            public void AddStock(int quantity)
            {
                if (quantity > 0)
                {
                    stockQuantity += quantity;s
                }
                else
                {
                    Console.WriteLine("Invalid stock quantity");
                }
            }

            public void Sell(int quantity)
            {
                if (quantity > 0 && quantity <= stockQuantity)
                {
                    stockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Invalid sell quantity");
                }
            }

            public override string ToString()
            {
                return "\nProduct Name: " + productName +
                       "\nPrice: " + price +
                       "\nStock Quantity: " + stockQuantity;
            }
        }

        static void Main(string[] args)
        {
            
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter initial stock quantity: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(name, price, stock);

    
            Console.Write("Enter quantity to add to stock: ");
            int addQty = Convert.ToInt32(Console.ReadLine());
            product.AddStock(addQty);

         
            Console.Write("Enter quantity to sell: ");
            int sellQty = Convert.ToInt32(Console.ReadLine());
            product.Sell(sellQty);

            
            Console.WriteLine("\nFinal Product Details:");
            Console.WriteLine(product);

            Console.ReadKey();
        }
    }
}