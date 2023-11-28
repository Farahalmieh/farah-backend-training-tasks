namespace simple_inventory_management_system {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
              
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        decimal price;
                        if (!decimal.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Invalid input for price. Please enter a valid number.");
                            break;
                        }

                        Console.Write("Enter product quantity: ");
                        int quantity;
                        if (!int.TryParse(Console.ReadLine(), out quantity))
                        {
                            Console.WriteLine("Invalid input for quantity. Please enter a valid number.");
                            break;
                        }

                        Product newProduct = new Product { Name = name, Price = price, Quantity = quantity };
                        inventory.AddProduct(newProduct);
                        break;

                    case 2:
                        inventory.ViewProduct();
                        break;

                    case 3:
                        Console.WriteLine("Enter Product Name");
                        string editName = Console.ReadLine();

                        Console.WriteLine("Enter New Product Name");
                        string newName = Console.ReadLine();

                        Console.WriteLine("Enter New Product Price");
                        decimal newPrice;

                        if (!decimal.TryParse(Console.ReadLine(), out newPrice))
                        {
                            Console.WriteLine("Invalid input for price. Please enter a valid number.");
                            break;
                        }

                        Console.WriteLine("Enter New Product Quantity");
                        int newQuantity;

                        if (!int.TryParse(Console.ReadLine(), out newQuantity))
                        {
                            Console.WriteLine("Invalid input for quantity. Please enter a valid number.");
                            break;
                        }

                        inventory.EditProduct(editName, newName, newPrice, newQuantity);

                        break;

                    case 4:

                        Console.WriteLine("Enter Product Name");
                        string deleteName = Console.ReadLine();
                        inventory.DeleteProduct(deleteName);

                        break;

                    case 5:

                        Console.WriteLine("Enter Product Name");
                        string searchName = Console.ReadLine();
                        inventory.SearchProduct(searchName);

                        break;

                    case 6:
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}