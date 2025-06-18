namespace ECommerceSearch
{
    public static class ProductData
    {
        public static Product[] GetProducts()
        {
            return new Product[]
            {
                new Product(103, "Laptop", "Electronics"),
                new Product(101, "Mouse", "Electronics"),
                new Product(104, "Shoes", "Footwear"),
                new Product(102, "Keyboard", "Electronics"),
                new Product(105, "T-shirt", "Clothing")
            };
        }
    }
}
