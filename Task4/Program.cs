//Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
//    Потрібно: Створити метод, який виконуватиме збільшення довжини масиву переданого як аргумент, 
//    на 1 елемент. Елементи масиву повинні зберегти своє значення та порядок індексів. 
//    Створіть метод, який приймає два аргументи, перший аргумент типу int [ ] array, другий аргумент 
//    типу int value. У тілі методу реалізуйте можливість додавання другого аргументу методу до 
//    масиву за індексом – 0, при цьому довжина нового масиву повинна збільшитися на 1 елемент, 
//    а елементи одержуваного масиву як перший аргумент мають скопіюватися в новий масив починаючи з індексу - 1. 
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1,2,3,4,5 };
            Console.Write("Enter value -> ");
            int value = Convert.ToInt32(Console.ReadLine());
            array = MyMethod(array, value);

            Console.WriteLine("New array -> ");
            for(int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");

        }
        static int[] MyMethod(int[] array, int value)
        {
            int[] newArray = new int[array.Length+1];
            for(int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            newArray[array.Length] = value;
            return newArray;
        }
    }
}