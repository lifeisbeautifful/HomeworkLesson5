using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask1
{
   /* Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая находит сумму  1+2+3+…+n, где число n вводится пользователем с клавиатуры*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            CalcSumOfNumber(number,sum);
            Console.ReadLine();
        }
        static void CalcSumOfNumber(int number,int sum)
        {
            while (number > 0)
            {
                sum = sum + number;
                number--; 
            }
            Console.WriteLine(sum);
        }
    }
}
