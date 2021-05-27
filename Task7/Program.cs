using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Написать программу, в которой создайте один метод, который будет вычислять площадь и периметр прямоугольника.Сторони прямоугольника 
    пользователь должен иметь возможность вводит с клавиатуры. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double rectangleWidth = double.Parse(Console.ReadLine());

            SquareAndPerimeter(rectangleLength, rectangleWidth);
            Console.ReadLine();
        }

        /// <summary>
        /// вичисляє периметр і площу прямокутника
        /// </summary>
        /// <param name="rectLength"></param>
        /// <param name="rectWidth"></param>
       
        static void SquareAndPerimeter(double rectLength, double rectWidth)
        {
           double rectanSquare = rectLength * rectWidth;
           double rectPerim = 2 * (rectLength + rectWidth);
           Console.WriteLine("Squre = {0}, perimeter = {1}",rectanSquare,rectPerim);
        }
    }
}
