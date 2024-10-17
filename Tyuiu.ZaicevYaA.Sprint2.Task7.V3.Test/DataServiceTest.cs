using Tyuiu.ZaicevYaA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 1.0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}