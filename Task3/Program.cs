//Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. Потрібно:
//1) Створити метод MyReverse(int [ ] array), який приймає як аргумент масив цілих чисел 
//    і повертає інвертований масив (елементи масиву у зворотному порядку).

//2) Створіть метод int [] SubArray (int[] array, int index, int count). 
//    Метод повертає частину отриманого як аргумент масиву, починаючи з позиції зазначеної 
//    в аргументі index, розмірністю, яка відповідає значенню аргументу count. 
//    Якщо аргумент count містить значення більше, ніж кількість елементів, 
//    які входять до частини вихідного масиву (від зазначеного індексу index, до індексу 
//    останнього елемента), то при формуванні нового масиву розмірністю в count, заповніть одиницями 
//    ті елементи, які не були скопійовані з вихідного масиву. 

using System;
using System.Globalization;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Original array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10);
                Console.Write(array[i]+" ");
            }
            array = MyReverse(array);
            Console.WriteLine("\nReverse array: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");

            Console.WriteLine("\nEnter index -> ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter count -> ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] subArray = SubArray(array, index, count);
            Console.WriteLine("\nSubArray: ");
            for (int i = 0; i < subArray.Length; i++)
                Console.Write(subArray[i]+" ");
        }

        static int[] MyReverse(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                reverseArray[j] = array[i];
                j++;
            }
            return reverseArray;
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[(int)count];
            int j = 0;
            for(int i = index; j<count; i++)
            {
                if(i<array.Length)
                {
                    subArray[j] = array[i];
                }
                else
                    subArray[j] = 1;
                j++;
            }
            return subArray;
        }
    }
}