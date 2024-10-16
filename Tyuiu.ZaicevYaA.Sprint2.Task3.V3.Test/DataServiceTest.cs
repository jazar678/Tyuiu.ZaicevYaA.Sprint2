using Tyuiu.ZaicevYaA.Sprint2.Task3.V3.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5 ;
            double res = ds.Calculate(x);
            double wait = 37.969;
            Assert.AreEqual(wait,res);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.082;
            Assert.AreEqual(wait, res);
        }
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.414;
            Assert.AreEqual(wait, res);
        }
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -8;
            double res = ds.Calculate(x);
            double wait = -15.875;
            Assert.AreEqual(wait, res);
        }
    }
}