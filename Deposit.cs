using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit
{
    class Deposit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double depositCopy = deposit;

            Console.WriteLine("Введите процентную ставку");
            double percentYear = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок размещения вклада, мес.");
            int depositDuration = Convert.ToInt32(Console.ReadLine());

            double income = 0;
            const int monthsInYear = 12;
            const int oneHundredPercent = 100;

            for (int j = 1; j <= depositDuration; j++)
            {
                income = depositCopy * (1 + percentYear / (oneHundredPercent * monthsInYear));
                depositCopy = income;
            }

            Console.WriteLine();
            Console.WriteLine("Доход = {0:f2}", income);
            Console.WriteLine();
            double profit = income - deposit;
            Console.WriteLine("Чистая прибыль = {0:f2}", profit);
        }
    }
}









//Console.WriteLine("Введите количество дней в текущем году");
//            int daysInYear = Convert.ToInt32(Console.ReadLine());

//int dayInMonth = 30;

//  sum = deposit * Math.Pow(1 + (percentYear * period) / (100 * daysInYear), n);