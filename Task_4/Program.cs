//Задание 4
//Пользователь вводит в строку с клавиатуры логическое
//выражение. Например, 3>2 или 7<3. Программа должна
//посчитать результат введенного выражения и дать резуль-
//тат true или false. В строке могут быть только целые числа
//и операторы: <, >, <=, >=, ==, !=.Для обработки ошибок
//ввода используйте механизм исключений.

using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Task_4
{
    internal class Program
    {
        static bool LogExpression(string a)
        {
            char[] symbols = { '<', '>', '=', '!' };
            int ind = a.IndexOfAny(symbols);
            int A, B;
            bool C;
            if (ind > 0)
            {
                A = Convert.ToInt32(a.Substring(0, ind));
                if (a[ind + 1] == '=')
                {
                    B = Convert.ToInt32(a.Substring(ind + 2, (a.Length - ind - 2)));
                    if (a[ind] == '<' && a[ind + 1] == '=')
                        return A <= B;
                    if (a[ind] == '>' && a[ind + 1] == '=')
                        return A >= B;
                    if (a[ind] == '=' && a[ind + 1] == '=')
                        return A == B;
                    if (a[ind] == '!' && a[ind + 1] == '=')
                        return A != B;
                }
                else
                    B = Convert.ToInt32(a.Substring(ind + 1, (a.Length - ind - 1)));
                if (a[ind] == '<')
                    return A < B;
                if (a[ind] == '>')
                    return A > B;
            }
            throw new Exception("Wrong Expression!");
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите логическое выражение целых чисел:");
            string log = Console.ReadLine();
                try
                {
                    Console.Write($"\tОтвет: {log} => {LogExpression(log)}\n\n");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }            
        }
    }
}