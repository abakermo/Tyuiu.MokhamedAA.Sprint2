using Tyuiu.MokhamedAA.Sprint2.Task6.V1.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int res = ds.FindMonthDaysCount(value);
            Assert.AreEqual(31, res);
        }
    }
}