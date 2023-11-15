// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication.Потрібно:
// Створити метод, який виконуватиме збільшення довжини масиву переданого як аргумент,
// на 1 елемент. Елементи масиву повинні зберегти своє значення та порядок індексів.
//
// Створіть метод, який приймає два аргументи, перший аргумент типу int [ ] array,
//другий аргумент типу int value.
//У тілі методу реалізуйте можливість додавання другого аргументу методу до масиву за індексом – 0,
//при цьому довжина нового масиву повинна збільшитися на 1 елемент,
//а елементи одержуваного масиву як перший аргумент мають скопіюватися
//в новий масив починаючи з індексу - 1. 

namespace Arrays
{
    class Program
    {
        // Створити метод, який виконуватиме збільшення довжини масиву переданого як аргумент,
        // на 1 елемент. Елементи масиву повинні зберегти своє значення та порядок індексів.
        static int[] Increasing(int[] array)
        {
            Array.Resize(ref array, array.Length + 1);
            Console.WriteLine("Новий збільшений масив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            return array;
        }

        // Створіть метод, який приймає два аргументи, перший аргумент типу int [ ] array,
        //другий аргумент типу int value.
        static int[] Adding(int[] array, int value) 
        {

            Array.Resize(ref array, array.Length + 1);

            for (int i = array.Length-2; i >=0; i--)
            {
                array[i+1] = array[i];
            }
            array[0] = value;
            Console.WriteLine("Другий новий збільшений масив:");
            for (int i = 0; i < array.Length; i++)
            {
                      Console.WriteLine(array[i]);
            }

                return array;
        }

        static void Main()
        {

            int[] array = { 1, 2, 3, 4 }; // перший масив
             
            Increasing(array);

            Console.ReadKey();


            Console.WriteLine("Введiть кількість елементiв масиву");// другий масив
            string x = Console.ReadLine();
            int X = Convert.ToInt32(x);
            int[] array2 = new int[X];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i + i * 5;
            }
            
            Console.WriteLine("Введiть значення другого аргументу"); // другий аргумент для другого масиву
            
            string y = Console.ReadLine();
            int Y = Convert.ToInt32(y);

            Adding(array2, Y);

        }
            
    }
}


