// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication.
// Створити масив розміру N елементів, заповнити його довільними цілими значеннями
// (розмір масиву задає користувач).
// Вивести на екран: найбільше значення масиву, найменше значення масиву,
// загальну суму всіх елементів, середнє арифметичне всіх елементів, вивести усі непарні значення. 


using System.Reflection;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть кількість елементiв масиву");
            string x = Console.ReadLine();
            int X = Convert.ToInt32(x);

            int[] array = new int[X];
            int sum = 0;

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + i*2;
                sum += array[i];
            }

            int middle = sum / X;
            Console.WriteLine();
            Console.WriteLine($"Minimum number is " + array.Min());
            Console.WriteLine($"Maximum number is " + array.Max());
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Middle is  {middle}");
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd is {array[i]}");
                }

                else { }


            // Delay.
            Console.ReadKey();
        }
    }
}
