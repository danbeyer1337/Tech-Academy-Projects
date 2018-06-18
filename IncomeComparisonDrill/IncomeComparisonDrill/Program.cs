using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Income Comparison Program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            //Person 1
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            int personOneRate;
            personOneRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int personOneHours;
            personOneHours = Convert.ToInt32(Console.ReadLine());
            //Person 2
            Console.WriteLine("Person 2");
            //Console.ReadLine();
            Console.WriteLine("Hourly rate?");
            int personTwoRate;
            personTwoRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int personTwoHours;
            personTwoHours = Convert.ToInt32(Console.ReadLine());

            int oneRateTotal = personOneRate * personOneHours;
            Console.WriteLine("Annual Salary of Person 1: " + oneRateTotal);

            int twoRateTotal = personTwoRate * personTwoHours;
            Console.WriteLine("Annual Salary of Person 2: " + twoRateTotal);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool whoMakesMore = oneRateTotal > twoRateTotal;
            Console.WriteLine(whoMakesMore);

            Console.ReadLine();
        }
    }
}
