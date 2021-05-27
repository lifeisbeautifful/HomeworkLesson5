using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Представьте, что вы реализуете программу для банка, которая 
    помогает определить, погасил ли клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн.Клиент
    должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн.Закрыть весь долг.
Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка.Метод выводит на экран информацию 
    о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга). */

    class Program
    {
        static void Main(string[] args)
        {
            double creditSum = 700;
            double interestPerYear = 11;
            double overpaid = 0;

            while (creditSum > 0)
            {
                double paymentAmount = double.Parse(Console.ReadLine());
                CreditAmount(ref creditSum, ref overpaid,paymentAmount,interestPerYear);
            }

         Console.ReadLine();
        }

        /// <summary>
        /// виводим дані про борг та переплату
        /// </summary>
        /// <param name="credit"></param>
        /// <param name="money"></param>
        /// <param name="overpaid"></param>
        static void CreditAmount(ref double credit, ref double overpaid,double money,double interest)
        {
            double interestPerMonth = (credit * interest/100)/12;
            if (credit <= money)
            {
                credit = 0;
                Console.WriteLine("The Debt is payed");
            }
            else
            {
                credit = credit + interestPerMonth - money;
                overpaid +=interestPerMonth;
                Console.WriteLine("The amount owed = {0}, overpayment amount = {1}", Math.Round(credit, 2), Math.Round(overpaid, 2));    
            }
            
        }
    }
}
