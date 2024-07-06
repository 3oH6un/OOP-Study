namespace YongBin._7장.ReadonlyFields;

class Configuration
{
    private readonly int min;
    private readonly int max;

    public Configuration(int v1, int v2)
    {
        min = v1;
        min = v2;
    }

//  public void ChangeMax(int newMax)
//  {
//      max = newMax;
//  }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        Configuration c = new Configuration(100, 10);
    }
}