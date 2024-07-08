namespace JiSup._7장.BasicClass;

public class Cat
{
    public string Name;
    public string Color;
    
    public Cat(String Name, string Color)
    {
        this.Name = Name;
        this.Color = Color;
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} : 야옹");
    }

}

public class MainApp
{
    public static void Main(string[] args)
    {
        Cat cat1 = new Cat("키티","Black");
        Cat cat2 = new Cat(Color: "White", Name: "블랙");
        // new 연산자 C#에서는 데이터형식도 생성자를 가지고있음 생성자를 호출해서 객체를 생성하는데 사용하는 연산자
        //int a= new int();와 같이 선언 가능
        // new 연산자 뒤에 메서드는 생성자라는 메서드로 특별한 메서드임 객체를 생성하는 역할을함
        // cat1,cat2는  Cat 클래스의 객체를 가리키는 역할 메모리가 할당되는것이 아니다.
        // 메모리를 할당시키기 위해서는 new 연산자를 사용해서 힙메모리 영억에 객체를 생성하고 cat1,cat2는 힙의 객체를 가리키게 된다.
        
        cat1.Meow();
        Console.WriteLine($"이 고양이 이름은 {cat1.Name} 이고  색상은 {cat1.Color} 입니다.");
        
        
        cat2.Meow();
        Console.WriteLine($"이 고양이 이름은 {cat2.Name} 이고  색상은 {cat2.Color} 입니다.");
        
    }
}