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
            return _Version;
        }
        private set
        {
            _Version = value;
        }
    }

    public int Version2 { get; set; }

    public double ThreeOverTwo { get => 3.0 / 2; }

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