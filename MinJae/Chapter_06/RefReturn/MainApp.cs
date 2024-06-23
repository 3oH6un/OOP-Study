namespace MinJae.Chapter_06.RefReturn;

public class MainApp
{
    static void _Main(string[] args)
    {
        Product carrot = new Product();
        ref int ref_local_price = ref carrot.GetPrice();
        int normal_local_price = carrot.GetPrice();

        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price : {ref_local_price}");
        Console.WriteLine($"Normal Local Price : {normal_local_price}");

        ref_local_price = 200;

        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price : {ref_local_price}");
        Console.WriteLine($"Normal Local Price : {normal_local_price}");
    }
}

class Product
{
    private int _price = 100;

    public ref int GetPrice()
    {
        return ref _price;
    }

    public void PrintPrice()
    {
        Console.WriteLine($"Price : {_price}");
    }
}