using Tyuiu.KotlovaEA.Sprint2.Task4.V29.Lib;
namespace Tyuiu.KotlovaEA.Sprint2.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 30;
            double wait = 363;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 2;
            double wait = 399;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
