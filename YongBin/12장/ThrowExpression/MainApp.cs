namespace YongBin._12장.ThrowExpression;

public class MainApp
{
    static void Main_(string[] args)
    {
        try
        {
            int? a = null;
            int b = a ?? throw new ArgumentNullException();
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e);
        }

        try
        {
            int[] array = new[] { 1, 2, 3 };
            int index = 4;
            int value = array[
                index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()
            ];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
    }
}