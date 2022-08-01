namespace CJackson;

public static class ProductExtensions
{
    public static string ProductNameAppenderExtension(this Product product)
    {
        return "The product name is " + product.Name;
    }
}