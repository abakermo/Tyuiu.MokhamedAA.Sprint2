using Tyuiu.MokhamedAA.Sprint2.Task4.V23.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1.129;
            Assert.AreEqual(wait, res);
        }
    }
}