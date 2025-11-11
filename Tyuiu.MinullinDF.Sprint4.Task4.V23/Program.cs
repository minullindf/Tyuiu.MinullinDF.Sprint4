using Tyuiu.MinullinDF.Sprint4.Task4.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите кол-во строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов в массиве: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++) 
            {
                Console.Write($"Введите {i}, {j} элемент массива: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.Calculate(array);
        Console.WriteLine($"Сумма нечетных элементов: {res}");
        Console.ReadKey();
    }
}