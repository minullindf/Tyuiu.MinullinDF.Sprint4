using Tyuiu.MinullinDF.Sprint4.Task0.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
        Console.WriteLine("{ 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 }");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.GetSumOddArrEl(array);
        Console.WriteLine($"Сумма нечетных чисел: {res}");
        Console.ReadKey();
    }
}