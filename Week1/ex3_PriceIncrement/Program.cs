using System.Text.Json;

namespace ex3_PriceIncrement
{
    
    //  Main class to execute the program
    class Program
    {
        static void Main()
        {
            //  Declare list uninitialized, cause if products loading fails it'll throw an exception and terminate
            // program execution
            List<Product> products;
            
            try
            {
                products = Product.LoadFromJson();
            }
            catch (Exception e)
            {
                //  If exception is thrown, catch it, print it and terminate program
                Console.WriteLine($"Products list was null: {e}");
                throw;
            }
            
            //  If no exceptions are thrown, continue execution processing the Product list
            CalculatePriceIncrement(products);
            
        }

        /// <summary>
        /// Calculates the price increment for each product and outputs their names and final prices
        /// </summary>
        /// <param name="products">
        /// Parameter of type List of Products, meaning it can load an array of products from the json file 
        /// </param>
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
        //  Properties with their getters and setters
        public string? Name { get; set; }
        public double? Price { get; set; }
        
        /// <summary>
        /// Static method because we'll use Products without instantiating it
        ///  This function loads a Product list from a json file. Could be null, and if it is, it'll throw an exception
        /// </summary> 
        /// <exception cref="NullReferenceException">
        /// If json loading happens to fail, this function will throw an exception to handle the error
        /// </exception>
        public static List<Product> LoadFromJson()
        {
            using (StreamReader r = new StreamReader("E:\\CSharp\\objectOrientedSystems\\Week1\\ex3_PriceIncrement\\products.json"))
            {
                string json = r.ReadToEnd();
                List<Product>? products = JsonSerializer.Deserialize<List<Product>>(json);
                if (products == null)
                {
                    //  Exception thrown here
                    throw new NullReferenceException();
                }
                //  Otherwise return the products list
                return products;
            }
        }
        
    }
    
}