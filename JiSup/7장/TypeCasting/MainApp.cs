namespace JiSup._7장.TypeCasting;

class Mammal
{
    public void Nurse()
    {
        Console.WriteLine("Nurse()");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Bark()");
    }
}


class Cat : Mammal
{
    public void Meow()
    {
        Console.WriteLine("Meow()");
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Mammal mammal = new Dog();
        Dog dog;
        
        if (mammal is Dog) // is사용 객체가 해당형식 객체에 해당하는지 검사하여 bool 값으로 출력
        {
            dog = (Dog)mammal; //mammal객체가 Dog형식임으로 안전하게 형식 변환이 이루어 진다.
            dog.Bark();
        }
        
        Mammal mammal2 = new Cat();

        Cat cat = mammal2 as Cat; //형식변환 연산자와 같은 역할 실패할경우 null로 만든다.
        
        if(cat != null)
            cat.Meow(); //null값이 아닐경우 cat객체의 method Meow()실행

        Cat cat2 = mammal as Cat;
        if (cat2 != null)
        {
            cat2.Meow();
        }
        else
        {
            Console.WriteLine("cat2 is not a Cat");
        }
    }
}