using Tyuiu.KotlovaEA.Sprint2.Task5.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (номер месяца) и n (число).                                  *");
        Console.WriteLine("* По заданным g, m и n определить дату следующего дня.                    *");
        Console.WriteLine("* Заданный год не является високосным.                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите год g: ");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер месяца m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string res = ds.FindDateOfNextDay(g, m, n);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Дата следующего дня: " + res);

        Console.ReadKey();
    }
}