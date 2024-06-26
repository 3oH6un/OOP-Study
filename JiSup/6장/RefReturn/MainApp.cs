﻿using System.Reflection.Metadata.Ecma335;

namespace JiSup._6장.RefReturn;

public class MainApp
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
        
    }

    public static void Main__(string[] args)
    {
        Product carrot = new Product();
        ref int ref_local_price = ref carrot.GetPrice();
        int noraml_local_price = carrot.GetPrice();
        
        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price : {ref_local_price}");
        Console.WriteLine($"Normal Local Price : {noraml_local_price}");

        ref_local_price = 200;

        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price : {ref_local_price}");
        Console.WriteLine($"Normal Local Price : {noraml_local_price}");
        
    }
}