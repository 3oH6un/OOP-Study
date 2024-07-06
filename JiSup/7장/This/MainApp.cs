using System.Dynamic;
using System.Security.Cryptography;

namespace JiSup._7장.This;

public class MainApp
{
    class Employee
    {
        private string Name;
        private string Postition;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPostition(string Postition)
        {
            this.Postition = Postition;
        }

        public string GetPosition()
        {
            return this.Postition;
        }


    }

    public static void _Main(string[] args)
    {
        Employee pooh = new Employee();
        pooh.SetName("Pooh");
        pooh.SetPostition("Waiter");
        Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

        Employee tigger = new Employee();
        tigger.SetName("Tigger");
        tigger.SetPostition("Cleaner");
        Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
    }
}