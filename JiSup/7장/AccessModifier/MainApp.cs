namespace JiSup._7장.AccessModifier;

class  WaterHeater
{
    protected int temperature;

    public void SetTemperatrue(int temperature)
    {
        if (temperature < -5 || temperature > 42)
        {
            throw new Exception("Out of temperature range");
        }

        this.temperature = temperature;
    }

    internal void TurnOnWater()
    {
        Console.WriteLine($"Turn on water : {temperature}");   
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        try
        {
            WaterHeater heater = new WaterHeater();
            heater.SetTemperatrue(20);
            heater.TurnOnWater();

            heater.SetTemperatrue(-2);
            heater.TurnOnWater();

            heater.SetTemperatrue(50);
            heater.TurnOnWater();
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}