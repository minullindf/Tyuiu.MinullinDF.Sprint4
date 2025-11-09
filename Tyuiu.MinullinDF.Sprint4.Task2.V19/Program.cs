using Tyuiu.MinullinDF.Sprint4.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[14];
        for (int i = 0; i < 14; i++)
        {
            array[i] = rnd.Next(4, 9);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.Calculate(array);
        Console.WriteLine($"Сумма нечетных чисел: {res}");
        Console.ReadKey();
    }
}