using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу консольный калькулятор.В данной программе должны быть четыре метода, метод для сложения, вычитания, 
    умножения и деления.Каждый из методов должен принимать 2 целочисленных аргумента и выполнять соответствующею действие. 
    Метод для деления должен выполнять проверку деления на ноль.Также необходимо предоставить пользователю возможность 
    вводить знак арифметической операции, в зависимости от знака вызывать соответствующий метод.Также пользователю необходимо 
    предоставить возможность вводит значения аргументов.  */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer value for operand 1: ");
            int operand1 = int.Parse(Console.ReadLine());

            Console.Write("Enter integer value for operand 2: ");
            int operand2 = int.Parse(Console.ReadLine());

            sign:
            Console.Write("Enter an arithmetic operation: ");
            string sign = Console.ReadLine();
          
            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}",operand1,operand2,Addition(operand1,operand2));
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}",operand1,operand2,Subtraction(operand1,operand2));
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}",operand1,operand2,Multiplication(operand1,operand2));
                    break;
                case "/":
                    Division(operand1, operand2);
                    break;
                default: goto sign;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// додаєм аргументи
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>суму аргументів</returns>
        static int Addition(int operand1,int operand2)
        {
            return operand1 + operand2;
        }

        /// <summary>
        /// віднімаєм від першого аргум другий
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        static int Subtraction(int operand1,int operand2)
        {
            return operand1 - operand2;
        }

        /// <summary>
        /// множимо аргументи
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>результат множення аргументів</returns>
        static int Multiplication(int operand1,int operand2)
        {
            return operand1 * operand2;
        }

        /// <summary>
        /// Ділимо перший аргум на другий
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        static void Division(int operand1,int operand2)
        {
            while (operand2 == 0)
            {
                Console.Write("Error, you are trying divide by zero, choose another integer for operand 2: ");
                operand2 = int.Parse(Console.ReadLine());
            }

            double operan1 = Convert.ToDouble(operand1);
            double operan2 = Convert.ToDouble(operand2);
            double result = operan1 / operan2;
            Console.WriteLine("{0} / {1} = {2}",operan1,operan2,Math.Round(result,2));
        }
    }
}
