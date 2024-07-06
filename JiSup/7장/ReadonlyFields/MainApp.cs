namespace JiSup._7장.ReadonlyFields;

class Configuratrion
{
    private readonly int min;
    private readonly int max;

    public Configuratrion(int v1, int v2)
    {
        min = v1;
        max = v2;
    }

    /*public void ChangeMax(int newMAX)
    {
        max = newMAX;
    }*/
}


public class MainApp
{
    public static void _Main(string[] args)
    {
        Configuratrion c = new Configuratrion(100,10);
    }
}