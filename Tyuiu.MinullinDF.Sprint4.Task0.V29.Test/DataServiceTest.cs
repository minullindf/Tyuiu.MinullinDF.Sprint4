using Tyuiu.MinullinDF.Sprint4.Task0.V29.Lib;
namespace Tyuiu.MinullinDF.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[10] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int wait = 32;
            var res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(wait, res);

        }
    }
}
