using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int a = matrix[i, j];
                    if (a > 0)
                    {
                        sum += a;
                    }
                }
            }
            return sum;
        }
    }
}
