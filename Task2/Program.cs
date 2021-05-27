using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу в которой создайте метод, который в качестве аргументов принимает 2 числа и возвращает меньшее из них.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to compare: ");
            Console.Write("First number = ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Second number = ");
            double secondNumber = double.Parse(Console.ReadLine());

            double compareResult = Compare(firstNumber, secondNumber);

            if (compareResult == 0)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("{0} is a smaller number",compareResult);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// порівнюєм 2 аргументи
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>повертаєм менше число
        /// </returns>
        static double Compare(double firstNum,double secondNum)
        {
            if (firstNum < secondNum)
            {
                return firstNum;
            }else if (secondNum == firstNum)
            {
                return 0;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
