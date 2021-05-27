using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson5
{
   /* Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
   Напишите программу в которой создайте метод, который принимает в качестве параметров три 
   целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers to calculate arithmetic mean: ");
            Console.Write("First number = ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second number = ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Third number = ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The average sum = {0}",CountAverage(firstNumber,secondNumber,thirdNumber));
            Console.ReadLine();
        }
 
        /// <summary>
        /// виводить середнє арифметичне
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <param name="thirdNum"></param>
        /// <returns>середнє арифметичне</returns>
        static double CountAverage(int firstNum,int secondNum,int thirdNum)
        {
            double firstNumb = Convert.ToDouble(firstNum);
            double secondNumb = Convert.ToDouble(secondNum);
            double thirdNumb = Convert.ToDouble(thirdNum);
            double average = (firstNumb + secondNumb+ thirdNumb) / 3;
            return Math.Round(average,2);
        }
        
    }
}
