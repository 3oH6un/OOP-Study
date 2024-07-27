namespace MinJae.Chapter_11.ConstraintsOnTypeParameters;

public class MainApp
{
    static void Main(string[] args)
    {
        StructArray<int> a = new StructArray<int>(3);
        a.Array[0] = 0;
        a.Array[1] = 1;
        a.Array[2] = 2;

        RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
        b.Array[0] = new StructArray<double>(5);
        b.Array[1] = new StructArray<double>(10);
        b.Array[2] = new StructArray<double>(1005);

        BaseArray<Base> c = new BaseArray<Base>(3);
        c.Array[0] = new Base();
        c.Array[1] = new Derived();
        c.Array[2] = CreateInstance<Base>();

        BaseArray<Derived> d = new BaseArray<Derived>(3);
        d.Array[0] = new Derived();
        d.Array[1] = CreateInstance<Derived>();
        d.Array[2] = CreateInstance<Derived>();

        BaseArray<Derived> e = new BaseArray<Derived>(3);
        e.CopyArray<Derived>(d.Array);


        BaseArray<Test1> x = new BaseArray<Test1>(4);
        BaseArray<Derived> y = new BaseArray<Derived>(4);
        y.CopyArray<Test1>(x.Array);


    }

    public static T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}

class StructArray<T> where T : struct
{
    public T[] Array { get; set; }

    public StructArray(int size)
    {
        Array = new T[size];
    }
}

class RefArray<T> where T : class
{
    public T[] Array { get; set; }

    public RefArray(int size)
    {
        Array = new T[size];
    }
}

class Base {}
class Derived : Base {}
class Test1 : Derived {}
class Test2 {}

class BaseArray<TBase> where TBase : Base
{
    public TBase[] Array { get; set; }

    public BaseArray(int size)
    {
        Array = new TBase[size];
    }

    public void CopyArray<TDerived>(TDerived[] source) where TDerived : TBase
    {
        source.CopyTo(Array, 0);
    }
}