// Create a main menu with working options to view all products,
// add a product to the inventory,
// delete a product from the inventory,
// and update a product's details
// Product Types have Name and Id properties.
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Name = "apparel"
    },
    new ProductType()
    {
        Id = 2,
        Name = "potion"
    },
    new ProductType()
    {
        Id = 3,
        Name = "enchanted object"
    },
    new ProductType()
    {
        Id = 4,
        Name = "wand"
    }
};

List<Product> products = new List<Product>()
{
    new Product()
    {
        // name
        Name = "magic robe",
        // price
        Price = 49.99M,
        // available
        Available = true,
        // producttypeid
        ProductTypeId = 1,
        // type as a reference i may need to delete this!!!
        Type = productTypes[0],
        // date stocked
        DateStocked = new DateTime(2022, 12, 20)
    }
};

string chosenOption = null;

while (chosenOption != "0")
{
    Console.WriteLine(@"choose one of the following:
    0. end program
    1. view all products
    2. add a product
    3. delete a product
    4. update a product's detail");

    chosenOption = Console.ReadLine();

    Console.WriteLine($"you chose option {chosenOption}.....");

    if (chosenOption == "0")
    {
        Console.WriteLine("goodbye");
    }
    else if (chosenOption == "1")
    {
        ViewAllProducts();
    }
    else if (chosenOption == "2")
    {
        AddAProduct();
    }
    else if (chosenOption == "3")
    {
        throw new NotImplementedException("delete a product");
    }
    else if (chosenOption == "4")
    {
        throw new NotImplementedException("update a product's detail");
    }
}
// method to view all products
void ViewAllProducts()
{
    foreach (Product product in products)
    {
        Console.WriteLine($"{product.Name} {(product.Available ? "is available" : "has sold")} for {product.Price} gems product is found in the {product.Type.Name} aisle... stocked on {product.DateStocked}");
    }
}
// method to add a product
void AddAProduct()
{
    Product newProduct = new Product();
    Console.WriteLine("enter the product's name...");
    newProduct.Name = Console.ReadLine();
    while (newProduct.Price == 0)
    {
        try
        {
            Console.WriteLine("enter the product's price...");
            newProduct.Price = decimal.Parse(Console.ReadLine().Trim());
        }
        catch (FormatException)
        {
            Console.WriteLine("you did not enter a price");
        }
    }
    newProduct.Available = true;
    // When adding a product to the inventory, the user should be able to choose from these options to add a product type id to the new product.
    while (newProduct.ProductTypeId == 0)
    {
        try
        {
            Console.WriteLine("choose one of the following product types");
            ViewAllProductTypes();
            newProduct.ProductTypeId = int.Parse(Console.ReadLine().Trim());
            // I SHOULDNT BE ABLE TO ADD A FOREIGN KEY MORE THAN THE PRODUCT TYPES AVAILABLE!!!
        }
        catch (FormatException)
        {
            Console.WriteLine($"enter a number between 1 and {productTypes.Count}");
        }
    }
    // lets find the matching product type and assign it to this product
    newProduct.Type = productTypes.First(product => product.Id == newProduct.ProductTypeId);
    Console.WriteLine($"the product's name is {newProduct.Name}");
    Console.WriteLine($"the product's price is {newProduct.Price}");
    Console.WriteLine($"the product's availability is {newProduct.Available}");
    Console.WriteLine($"the product's foreign key is {newProduct.ProductTypeId}");
    products.Add(newProduct);
}
// method to view all product types
void ViewAllProductTypes()
{
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine(@$"{i + 1}. {productTypes[i].Name}");
    }
}
// Red and Abe should be able to look up products in their database by product type.