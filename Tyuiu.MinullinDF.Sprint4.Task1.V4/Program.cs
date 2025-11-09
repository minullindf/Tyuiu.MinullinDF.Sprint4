using Tyuiu.MinullinDF.Sprint4.Task1.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
        Console.WriteLine("{ 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 }");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.Calculate(array);
        Console.WriteLine($"Сумма нечетных чисел: {res}");
        Console.ReadKey();
    }
}