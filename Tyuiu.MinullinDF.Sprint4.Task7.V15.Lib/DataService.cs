using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task7.V15.Lib
{
    public class DataService : ISprint4Task7V15
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    if (int.Parse(value[i * m + j].ToString()) % 2 != 0) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
