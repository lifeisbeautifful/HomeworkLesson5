using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая будет вычислять сумму цифр числа N.Число N пользователь должен вводить с клавиатуры. При решении
    этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). (Использовать рекурсию)*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine(SumOfDigits(number,sum));
            Console.ReadLine();
        }
        
        /// <summary>
        /// вичисляєм суму цифр
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        static int SumOfDigits(int n,int sum)
        {
            sum = sum + n % 10;
            if (n > 9)
            {
                return SumOfDigits(n/10,sum);
            }
            return sum;
        }
    }
}
