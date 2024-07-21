using System.Runtime.InteropServices.JavaScript;

namespace JiSup._9장.PropertiesInAbstractClass;

abstract class Product
{
    private static int serial = 0;

    public string SerialID
    {
        get { return String.Format("{0:d5}", serial++); }
    }

    abstract public DateTime ProductDate
    {
        get;
        set;
    }
    
}

class MyProduc : Product
{
    public override DateTime ProductDate
    {
        get;
        set;
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Product product_1 = new MyProduc() { ProductDate = new DateTime(2023, 1, 10) };

        Console.WriteLine("Product : {0}, Product Date : {1}",product_1.SerialID,product_1.ProductDate);
        
        Product product_2 = new MyProduc() { ProductDate = new DateTime(2023, 2, 3) };
        
        Console.WriteLine("Product : {0}, Product Date : {1}",product_2.SerialID,product_2.ProductDate);
    }
}