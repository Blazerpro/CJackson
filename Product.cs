namespace CJackson;

public class Product : object
{
    public string Name;

    // backing field
    private int _Version;

    // Property
    public int Version
    {
        get
        {
            return _Version + 1;
        }
        private set
        {
            _Version = value;
        }
    }

    public override string ToString()
    {
        return ProductNameAppender();
    }

    public Product(string name, int version)
    {
        Name = name;
        Version = version;
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