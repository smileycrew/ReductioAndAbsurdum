// Create a main menu with working options to view all products,
// add a product to the inventory,
// delete a product from the inventory,
// and update a product's details
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
        // type as a reference
        Type = productTypes[0]
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

    Console.WriteLine($"you chose option {chosenOption}");

    if (chosenOption == "0")
    {
        Console.WriteLine("goodbye");
    }
    else if (chosenOption == "1")
    {
        throw new NotImplementedException("view all plants");
    }
    else if (chosenOption == "2")
    {
        throw new NotImplementedException("add a product");
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
// When adding a product to the inventory, the user should be able to choose from these options to add a product type id to the new product.

// Product Types have Name and Id properties.

// Red and Abe should be able to look up products in their database by product type.