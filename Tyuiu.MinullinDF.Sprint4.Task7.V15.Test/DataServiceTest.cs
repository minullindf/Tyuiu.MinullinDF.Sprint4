using Tyuiu.MinullinDF.Sprint4.Task7.V15.Lib;
namespace Tyuiu.MinullinDF.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "10293847";
            var res = ds.Calculate(4, 2, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
