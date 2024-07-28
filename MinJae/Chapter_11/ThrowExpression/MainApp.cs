namespace MinJae.Chapter_11.ThrowExpression;

public class MainApp
{
    static void _Main(string[] args)
    {
        try
        {
            int? a = null;
            int b = a ?? throw new ArgumentNullException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }

        try
        {
            int[] array = new[] { 1, 2, 3 };
            int index = 4;
            int value = array[
                index >= 0 && index < 3
                    ? index
                    : throw new IndexOutOfRangeException()
            ];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
    }
}