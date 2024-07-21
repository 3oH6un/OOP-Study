namespace MinJae.Chapter_08.PropertiesInAbtractClass;

public class MainApp
{
    static void _Main(string[] args)
    {
        Product product1 = new MyProduct() { ProductDate = new DateTime(2023, 1, 10) };
        Console.WriteLine("Product:{0}, Product Date:{1}", product1.SerialID, product1.ProductDate);

        Product product2 = new MyProduct() { ProductDate = new DateTime(2023, 2, 3)};
        Console.WriteLine("Product:{0}, Product Date:{1}", product2.SerialID, product2.ProductDate);
    }
}

abstract class Product
{
    private static int _serial = 0;

    public string SerialID
    {
        get { return String.Format("{0:d5}", _serial++); }
    }

    abstract public DateTime ProductDate { get; set; }
}

class MyProduct : Product
{
    public override DateTime ProductDate { get; set; }
}