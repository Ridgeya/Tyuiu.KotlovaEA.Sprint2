using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KotlovaEA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if (y >= 0.5 && y <= Math.Sin(x))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
