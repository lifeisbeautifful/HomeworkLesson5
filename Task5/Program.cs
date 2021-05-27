using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу для конвертирования валюты.Пользователь должен иметь возможность ввести курс валюты, в которую он хочет 
    конвертировать, сумму которую он хочет конвертировать.Программа должна вывести сумму денег в соответствующей валюте.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount in UAH: ");
            double amount = double.Parse(Console.ReadLine());
            while (amount < 0)
            {
                Console.Write("Enter positive amount: ");
                amount = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the currency to convert: ");
            Console.Write("USD, EUR, PLN, RUB: ");
            string currency = Console.ReadLine();

            ConvertMoney(amount,currency);
            Console.ReadLine();
        }

        /// <summary>
        /// конвертує у відповідну валюту
        /// </summary>
        /// <param name="money"></param>
        /// <param name="currency"></param>
        static void ConvertMoney(double money,string currency)
        {
             switch (currency)
            {
                case "USD":
                    Console.WriteLine("{0} UAH = {1} USD",money,Math.Round(money/27.4665,4));
                    break;
                case "EUR":
                    Console.WriteLine("{0} UAH = {1} EUR",money,Math.Round(money/33.5174,4));
                    break;
                case "PLN":
                    Console.WriteLine("{0} UAH = {1} PLN",money,Math.Round(money/7.4294,4));
                    break;
                case "RUB":
                    Console.WriteLine("{0} UAH = {1} RUB",money,Math.Round(money/0.3730,4));
                    break;
                default: Console.WriteLine("Cannot convert to such currency!");
                    break;
            }
        }
    }
}
