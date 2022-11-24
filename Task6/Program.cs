//Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
//    Створіть масив розмірністю 10 елементів, виведіть на екран усі елементи масиву у зворотному порядку.
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] ;
            Console.WriteLine("Original: ");
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                array[i] = random.Next(100);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("\nReverse: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
               Console.Write(array[i]+" ");
            }
        }
    }
}