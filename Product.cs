namespace CJackson;

public class Product : object
{
    public string Name;

    public override string ToString()
    {
        return Name;
    }

    public Product(string name)
    {
        Name = name;
    }
}