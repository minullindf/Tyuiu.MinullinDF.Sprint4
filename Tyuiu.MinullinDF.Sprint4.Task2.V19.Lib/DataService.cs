using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    s += item;
                }
            }
            return s;
        }
    }
}
