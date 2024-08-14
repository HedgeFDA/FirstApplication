using System; // Подключенное пространство имен

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, сколько будет 2+2*2?");
            string answer = Console.ReadLine();
            if (answer == "6")
            {
                Console.WriteLine("Угадали, будет {0} ", answer);
            }
            else
            {
                Console.WriteLine("Не угадали, будет не {0}", answer);
            }
        }
    }
}