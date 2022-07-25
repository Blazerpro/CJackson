namespace CJackson;

public class Product : object
{
    public string Name;

    public override string ToString()
    {
        return ProductNameAppender();
    }

    public Product(string name)
    {
        Name = name;
    }

    public string ProductNameAppender()
    {
        return "The product name is " + Name;
    }

    public static string ProductNameAppender(Product product)
    {
        return "The product name is " + product.Name;
    }


}