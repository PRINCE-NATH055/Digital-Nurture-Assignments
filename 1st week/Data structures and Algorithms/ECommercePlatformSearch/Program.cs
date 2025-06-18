using System;

namespace ECommerceSearch
{
    class Program
    {
        static void Main()
        {
            Product[] products = ProductData.GetProducts();

            Console.WriteLine("Linear Search (by Name: 'Shoes'):");
            var result1 = Search.LinearSearch(products, "Shoes");
            Console.WriteLine(result1 != null ? $"Found: {result1}" : "Product not found.");

            Console.WriteLine("\nBinary Search (by ID: 102):");
            var result2 = Search.BinarySearch(products, 102);
            Console.WriteLine(result2 != null ? $"Found: {result2}" : "Product not found.");
        }
    }
}
