// Products have a name, price (as a decimal), and a boolean to indicate whether they are still available. 
// They also have a ProductTypeId, which categorize them into the following categories: apparel, potions, enchanted objects, and wands.

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }
    public int ProductTypeId { get; set; }
    // navigation property i may need to get rid of this
    public ProductType Type { get; set; }
    public DateTime DateStocked { get; set; }
}

public class ProductType
{
    public int Id { get; set; }
    public string Name { get; set; }
}