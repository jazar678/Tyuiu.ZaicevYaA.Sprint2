using Tyuiu.ZaicevYaA.Sprint2.Task4.V6.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 420.6;
            Assert.AreEqual(wait,res);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.6479999999999999;
            Assert.AreEqual(wait, res);
        }
    }
}