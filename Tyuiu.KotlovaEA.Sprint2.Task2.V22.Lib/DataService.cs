using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KotlovaEA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 3 && ((x >= 3 && x <= 5) || (x >= 9 && x <= 12))) return true;
            if (y == 4 && ((x >= 3 && x <= 5) || (x >= 9 && x <= 12))) return true;
            if (y == 5 && (x >= 3 && x <= 12)) return true;
            if (y == 6 && (x >= 3 && x <= 13)) return true;
            if (y == 7 && (x >= 3 && x <= 12)) return true;
            if (y == 8 && ((x >= 3 && x <= 4) || (x >= 9 && x <= 12))) return true;
            if (y == 9 && ((x >= 3 && x <= 4) || x == 10)) return true;
            if (y == 10 && ((x >= 3 && x <= 4) || x == 10)) return true;
            if (y == 11 && ((x >= 2 && x <= 4) || x == 10)) return true;
            if (y == 12 && x == 3) return true;
            if (y == 13 && x == 3) return true;
            if (y == 14 && (x >= 3 && x <= 8)) return true;

            return false;
        }
    }
}
