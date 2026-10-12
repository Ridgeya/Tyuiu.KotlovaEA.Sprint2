using Tyuiu.KotlovaEA.Sprint2.Task6.V15.Lib;
namespace Tyuiu.KotlovaEA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDayName(366);
            });
        }
    }
}
