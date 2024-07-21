namespace JiSup._10장.MoreOnArray;

public class MainApp
{
    
    private static bool checkPassed(int score)
    {
        return score >= 60;
    }

    private static void Print(int value)
    {
        Console.Write($"{value} ");
    }
    
    
    public static void _Main(string[] args)
    {

        int[] scores = new int[] { 80, 74, 81, 90, 34 };
        
        foreach (int score in scores)
            Console.Write($"{score} ");
        Console.WriteLine();
        
        Array.Sort(scores);
        Array.ForEach<int>(scores, new Action<int>(Print));
        Console.WriteLine();

        Console.WriteLine($"Number of dimensions : {scores.Rank}");

        Console.WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

        Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, checkPassed)}");

        int index = Array.FindIndex<int>(scores, (score) => score < 60);

        scores[index] = 61;
        Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, checkPassed)}");

        Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");
        
        Array.Resize<int>(ref scores, 10);
        Console.WriteLine($"New length of scores : {scores.Length}");
        
        Array.ForEach<int>(scores, new Action<int>(Print));
        Console.WriteLine();
        
        Array.Clear(scores, 3, 7);
        Array.ForEach<int>(scores, new Action<int>(Print));
        Console.WriteLine();

        int[] sliced = new int[3];
        Array.Copy(scores, 0, sliced, 0, 3);
        Array.ForEach<int>(sliced, new Action<int>(Print));
        Console.WriteLine();

    }
}