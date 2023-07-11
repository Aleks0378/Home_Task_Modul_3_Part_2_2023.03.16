//Задание 2
//Пользователь вводит словами цифру от 0 до 9. Прило-
//жение должно перевести слово в цифру. Например, если
//пользователь ввёл five, приложение должно вывести на
//экран 5.

namespace Task_2
{
    internal class Program
    {
        static int WordToInt(string w)
        {
            switch(w)
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    Console.WriteLine("Error. The entered data is not valid.");
                    return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number from 0 to 9 by word: ");
            string a= Console.ReadLine();
            if (a == " " || a.Length == 0)
                Console.WriteLine("You have entered an empty row.");
            else Console.WriteLine($"Your number is {WordToInt(a)}");

        }
    }
}