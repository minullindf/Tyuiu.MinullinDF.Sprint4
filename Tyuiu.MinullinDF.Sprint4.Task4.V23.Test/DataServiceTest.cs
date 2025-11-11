using Tyuiu.MinullinDF.Sprint4.Task4.V23.Lib;
namespace Tyuiu.MinullinDF.Sprint4.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] {
                { 8, 7, 5, 8, 7 },
                { 8, 3, 3, 6, 4 },
                { 4, 4, 5, 5, 4 },
                { 3, 4, 7, 7, 3 },
                { 6, 8, 3, 6, 7 }
            };
            int wait = 65;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
