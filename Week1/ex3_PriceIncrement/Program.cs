using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace ex3_PriceIncrement
{
    
    
    class Program
    {
        static void Main()
        {
            List<Product> products;
            try
            {
                products = Product.LoadFromJson();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Products list was null: {e}");
                throw;
            }
            
            CalculatePriceIncrement(products);
            
        }

        static void CalculatePriceIncrement(List<Product> products)
        {
            //  Iterate once to increment the prices (low performance, I know, but it's a practice...)
            foreach (Product product in products)
            {
                product.Price *= 1.15;
            }
            
            //  Iterate a second time to print all the products
            foreach (Product product in products)
            {
                Console.WriteLine($"Product.name = {product.Name}");
                Console.WriteLine("Product.price = {0:N2}\n", product.Price);
            }
        }
        
    }

    public class Product
    {
        public string? Name { get; set; }
        public double? Price { get; set; }
        
        public static List<Product> LoadFromJson()
        {
            using (StreamReader r = new StreamReader("E:\\CSharp\\objectOrientedSystems\\Week1\\ex3_PriceIncrement\\Products.json"))
            {
                string json = r.ReadToEnd();
                List<Product>? items = JsonSerializer.Deserialize<List<Product>>(json);
                if (items == null)
                {
                    throw new NullReferenceException();
                }
                return items;
            }
        }
        
    }
    
}