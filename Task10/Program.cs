using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое число и определяет количество разрядов данного 
    числа.Пользователь должен иметь возможность вводит число с клавиатуры*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            CountDigitsOfNumber(number);
            Console.ReadLine();
        }

        /// <summary>
        /// вираховуєм розрядність числа
        /// </summary>
        /// <param name="num"></param>
        static void CountDigitsOfNumber(int num)
        {
            if (num < -9)
            {
                int counter = 1;
                while(num < -9)
                {
                    num = num / 10;
                    counter++;
                }
                Console.WriteLine("{0} digit number",counter);
            }else if(num >= -9 && num < 10)
            {
                Console.WriteLine("single-digit number");
            }
            else
            {
                int counter = 1;
                while (num > 9)
                {
                    num = num / 10;
                    counter++;
                }
                Console.WriteLine("{0} digit number",counter);
            }
        }
        }
    }

