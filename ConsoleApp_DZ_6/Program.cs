// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication.
// Створіть масив розмірністю 10 елементів,
// виведіть на екран усі елементи масиву у зворотному порядку.

namespace Arrays
{
    class Program
    {

        static void Main()
        { int[] array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + i * 5;
            }

            for (int i = 0; i < array.Length; i++)

            Console.Write(array[i] + " ");
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; --i)
                Console.Write(array[i] + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}