namespace ECommerceSearch
{
    public static class Search
    {
        public static Product LinearSearch(Product[] products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, int targetId)
        {
            Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == targetId)
                    return products[mid];
                else if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
    }
}
