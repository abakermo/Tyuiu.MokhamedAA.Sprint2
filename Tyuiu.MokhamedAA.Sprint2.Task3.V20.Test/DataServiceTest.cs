using Tyuiu.MokhamedAA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}