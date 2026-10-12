using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KotlovaEA.Sprint2.Task4.V29.Lib
{
    public class DataService : ISprint2Task4V29
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 3 < y + 2 - 20)
                ? 2 * x + 12 * y - (2 / x)
                : x * x - (2 / y);

            return Math.Round(z, 3);
        }
    }
}
