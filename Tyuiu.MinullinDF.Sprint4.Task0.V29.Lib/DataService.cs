using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int s = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0) 
                {
                    s += i;
                }
            }
            return s;
        }
    }
}
