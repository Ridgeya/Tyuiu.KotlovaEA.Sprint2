using Tyuiu.KotlovaEA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.KotlovaEA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 3 * Math.Pow((3.0 + 1) / (3.0 - 1), 3);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = (0.0 - 1 + 10) / (0 - 0 + 12);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = Math.Pow(1 + 1.0 / (4), -2);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -30 + 10 * (-30) - (1.0 / -30);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
