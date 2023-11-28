namespace simple_inventory_management_system
{
	public class Inventory
	{
		private List<Product> products = new List<Product>();

		public void AddProduct (Product product)
		{
			products.Add(product);
		}

        public void ViewProduct()
        {
            if (!products.Any())
            {
                Console.WriteLine("empty");
                return;
            }
           
            foreach (var product in products)
            {
                Console.WriteLine($"name: {product.Name}, price: {product.Price}, quantity: {product.Quantity}");
            }
        }

		public void EditProduct(string productName, string newName, decimal newPrice, int newQuantity)
		{
			Product productToEdit = products.Find(product => product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (productToEdit == null)
			{
                Console.WriteLine("product not found");
                return;
            }

			productToEdit.Name = newName;
            productToEdit.Price = newPrice;
            productToEdit.Quantity = newQuantity; 
        }

        public void DeleteProduct(string ProductName)
        {
            Product productToDelete = products.Find(p => p.Name.Equals(ProductName, StringComparison.OrdinalIgnoreCase));

            if (productToDelete == null)
            {
                Console.WriteLine("product not found");
                return;
            }

            products.Remove(productToDelete);
        }
            

        public void SearchProduct(string ProductName)
        {
            Product productToSearch = products.Find(p => p.Name.Equals(ProductName, StringComparison.OrdinalIgnoreCase));
          
            if (productToSearch == null)
            {
                Console.WriteLine("product not found");
                return;
            }

            Console.WriteLine($"name:{productToSearch.Name}, price:{productToSearch.Price}, quantity{productToSearch.Quantity}");
        }
    }
}