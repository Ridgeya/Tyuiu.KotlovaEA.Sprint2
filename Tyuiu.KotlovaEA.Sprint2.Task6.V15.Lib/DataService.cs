using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KotlovaEA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException($"Некорректное значение k: {k}");
            }
            switch (k % 7)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 0: return "Воскресенье";
                default: throw new ArgumentException($"Некорректное значение k: {k}");
            }
        }
    }
}
