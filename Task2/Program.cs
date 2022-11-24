//Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
//    Створити масив розміру N елементів, заповнити його довільними цілими значеннями
//    (розмір масиву задає користувач). 
//    Вивести на екран: найбільше значення масиву, найменше значення масиву, 
//    загальну суму всіх елементів, середнє арифметичне всіх елементів, вивести усі непарні значення. 

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of elements -> ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(100);
            }
            int sum = 0;
            Console.WriteLine("Нечетньіе: ");
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
                if (arr[i]%2!=0)
                    Console.Write(arr[i]);
            }

            Console.WriteLine("\nMax = " + arr.Max() + "Min = " + arr.Min()+"Sum = "+sum+" Avg = "+(sum/length));            
        }
    }
}