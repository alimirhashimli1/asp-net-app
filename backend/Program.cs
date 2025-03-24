using Newtonsoft.Json;


public class Product 
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public List<string> Tags { get; set; }
}

public class Program
{
    public static void Main()
    {
        string json = "{ \"Name\": \"Laptop\", \"Price\": 1000, \"Tags\": [\"Laptop\", \"Electronics\"] }";
        Product product = JsonConvert.DeserializeObject<Product>(json);

        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine($"Tags: {string.Join(", ", product.Tags)}");
    }
}