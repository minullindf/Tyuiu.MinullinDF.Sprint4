using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MinullinDF.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            int b = 0;
            foreach (var item in array)
            {
                if (item.Length < 7) 
                {
                    b++;
                }
            }
            string[] a = new string[b];
            int c = 0;
            foreach (var item in array)
            {
                if (item.Length < 7)
                {
                    a[c] = item;
                    c++;
                }
            }
            return a;
        }
    }
}
