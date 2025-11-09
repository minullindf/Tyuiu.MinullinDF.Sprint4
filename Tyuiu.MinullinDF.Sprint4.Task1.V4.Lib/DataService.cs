using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int s = 1;
            foreach (int item in array) 
            {
                if (item % 2 != 0) 
                {
                    s *= item;
                }
            }
            return s;
        }
    }
}
