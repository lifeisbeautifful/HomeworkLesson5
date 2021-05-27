using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который принимает в качестве аргумента год рождения пользователя и возвращает его 
    полный возраст.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("You are/will be {0} years old this year",CalcAge(yearOfBirth));
            Console.ReadLine();
        }

        /// <summary>
        /// вираховуєм вік
        /// </summary>
        /// <param name="year"></param>
        /// <returns>к-сть років</returns>
        static int CalcAge(int year)
        {
            int currentYear =DateTime.Now.Year;
            return currentYear - year;
        }
    }
}
