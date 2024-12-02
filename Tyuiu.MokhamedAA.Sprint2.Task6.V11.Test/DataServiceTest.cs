using Tyuiu.MokhamedAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int g = 2004;
            int m = 4;
            int n = 1;
            DataService ds = new DataService();
            Assert.AreEqual("31.03.2004", ds.FindDateOfNextDay(g, m, n));
        }
    }
}