namespace MinJae.Chapter_07.ReadOnlyFields;

public class MainApp
{
    static void _Main(string[] args)
    {
        Configuration c = new Configuration(100, 10);
    }
}

class Configuration
{
    private readonly int _min;
    private readonly int _max;

    public Configuration(int v1, int v2)
    {
        _min = v1;
        _max = v2;
    }

    // public void ChangeMax(int newMax)
    // {
    //     _max = newMax;
    // }
}