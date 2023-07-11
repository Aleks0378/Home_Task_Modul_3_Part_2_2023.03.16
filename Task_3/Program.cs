//Задание 3
//Создайте класс «Заграничный паспорт». Вам необходимо
//хранить информацию о номере паспорта, ФИО владельца,
//дате выдачи и т.д. Предусмотреть механизмы для инициа-
//лизации полей класса. Если значение для инициализации
//неверное, генерируйте исключение.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ForeignPasport newpasport = new ForeignPasport();
            try
            {
              newpasport.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(newpasport);
        }
    }
}