using Tyuiu.ZaicevYaA.Sprint2.Task2.V8.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false ;
            Assert.AreEqual(wait, res);

        }
    }
}