using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который принимает в качестве параметров три целочисленных значения и возвращает 
    значение каждого аргумента, умноженного на 10.
(Использовать out и ref)*/

    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 20;
            int thirdNum = 30;

            MultiplyBy10(ref firstNum,ref secondNum,ref thirdNum,out firstNum,out secondNum,out thirdNum);
            Console.ReadLine();
        }

        /// <summary>
        /// множимо аргументи на 10
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
       
        static void MultiplyBy10(ref int firstNumber,ref int secondNumber,ref int thirdNumber,out int firstNumResult,out int secondNumResult, out int thirdNumResult)
        {
            firstNumResult = firstNumber * 10;
            secondNumResult = secondNumber * 10;
            thirdNumResult = thirdNumber * 10;
            Console.WriteLine("The multiplication results: {0}, {1},{2}",firstNumResult,secondNumResult,thirdNumResult);
        }
    }
}
