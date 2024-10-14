using Tyuiu.ZaicevYaA.Sprint2.Task0.V16.Lib;
namespace Tyuiu.ZaicevYaA.Sprint2.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1025;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}