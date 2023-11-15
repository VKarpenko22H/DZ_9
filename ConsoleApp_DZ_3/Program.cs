//Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. Потрібно:

//1) Створити метод MyReverse(int [ ] array), який приймає як аргумент масив цілих чисел
//і повертає інвертований масив (елементи масиву у зворотному порядку).

//2) Створіть метод int [] SubArray (int [] array, int index, int count).
//Метод повертає частину отриманого як аргумент масиву,
//починаючи з позиції зазначеної в аргументі index,
//розмірністю, яка відповідає значенню аргументу count.
//Якщо аргумент count містить значення більше, ніж кількість елементів,
//які входять до частини вихідного масиву
//(від зазначеного індексу index, до індексу останнього елемента),
//то при формуванні нового масиву розмірністю в count,
//заповніть одиницями ті елементи, які не були скопійовані з вихідного масиву. 


using System;
using System.Reflection;

namespace Arrays
{
    class Program
    {

       
        // метод MyReverse(int [ ] array)
        static void MyReverse(int[] array)
        {

            // Вывод на экран значений элементов массива.
            Console.WriteLine("Масив та інвертований масив");
            for (int i = 0; i < array.Length; i++)
            
                Console.Write(array[i] + " ");
                Console.WriteLine();


            for (int i = array.Length - 1; i >= 0; --i)
                Console.Write(array[i] + " ");
                Console.WriteLine();


        }
        //метод int [] SubArray (int [] array, int index, int count)

        static void SubArray(int[] array, int index, int count)
        {
            
            int[] array2 = new int[count];

            for (int i = 0; i < count; i++)
            {
                int j = i + index;
                if (j >= array.Length)
                    array2[i] = 1;
                else
                    array2[i] = array[j];
            }
            for (int i = 0; i < array2.Length; i++)
            {
               Console.Write(array2[i] + " ");
            }
            Console.WriteLine();

        }

        static void Main()
        {

        Console.WriteLine("Введiть кількість елементiв масиву");
        string x = Console.ReadLine();
        int X = Convert.ToInt32(x);

        Console.WriteLine("Введiть індекс");
        string y = Console.ReadLine();
        int index = Convert.ToInt32(y);

        Console.WriteLine("Введiть розмірність");
        string z = Console.ReadLine();
        int count = Convert.ToInt32(z);


        int[] array = new int[X];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + i * 3;
        }
            Console.WriteLine();
            MyReverse(array);
            Console.WriteLine("новий масив");
            SubArray(array, index, count);


        Console.ReadKey();
        }
    }

}

   