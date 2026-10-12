using Tyuiu.KotlovaEA.Sprint2.Task3.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
        Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь         *");
        Console.WriteLine("* вводит значение переменной X с клавиатуры.                              *");
        Console.WriteLine("* Округлить полученное значение до 3 знаков после запятой.                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*           (x + 1) ^ x                                                   *");
        Console.WriteLine("* y = x * ( --------- )          , если x > 1                             *");
        Console.WriteLine("*           (x - 1)                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*           x^2 - cos^2(x) + 10                                           *");
        Console.WriteLine("* y = --------------------------- , если x = 0                            *");
        Console.WriteLine("*           x^2 - sin^2(x) + 12                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*              1                                                          *");
        Console.WriteLine("* y = ( 1 + ------- ) ^ x        , если -24 < x < 2                       *");
        Console.WriteLine("*             x^2                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                   1                                                     *");
        Console.WriteLine("* y = x + 10x - -----            , если x < -24                           *");
        Console.WriteLine("*                   x                                                     *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}