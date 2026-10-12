using Tyuiu.KotlovaEA.Sprint2.Task4.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованием тернарного оператора, где пользователь вводит            *");
        Console.WriteLine("* значения переменных x, y с клавиатуры:                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*   если x - 3 < y + 2 - 20,                                              *");
        Console.WriteLine("*     то z = 2x + 12y - (2/x)                                             *");
        Console.WriteLine("*   иначе:                                                                *");
        Console.WriteLine("*       z = x^2 - (2/y)                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}