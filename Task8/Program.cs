using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который выведет все числа от 1 до N.N – число которое пользователь вводит с клавиатуры.
    (Использовать рекурсию)*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int enteredNumb = int.Parse(Console.ReadLine());
            
            PrintNumbers(enteredNumb);
            Console.ReadLine();
        }

        /// <summary>
        /// вивести числа від 1 до інпуту
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static void PrintNumbers(int n)
        {
            if (n > 1)
            {
                PrintNumbers(n - 1);
            }
            Console.WriteLine(n);
           
        }
    }
}
