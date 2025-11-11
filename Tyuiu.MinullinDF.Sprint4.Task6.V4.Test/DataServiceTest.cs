using Tyuiu.MinullinDF.Sprint4.Task6.V4.Lib;
namespace Tyuiu.MinullinDF.Sprint4.Task6.V4.Lib.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            var res = ds.Calculate(array);
            string[] wait = { "Москва", "Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
