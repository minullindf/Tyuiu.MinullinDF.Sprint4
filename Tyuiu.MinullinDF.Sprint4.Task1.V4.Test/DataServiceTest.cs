using Tyuiu.MinullinDF.Sprint4.Task1.V4.Lib;
namespace Tyuiu.MinullinDF.Sprint4.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int wait = 2835;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
