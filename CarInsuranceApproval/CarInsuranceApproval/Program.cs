using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge;
            userAge = Convert.ToInt32(Console.ReadLine());
            //bool oldEnough = (userAge >= 15);
            //Console.WriteLine(oldEnough);

            Console.WriteLine("Have you ever had a DUI?");
            bool x;
            string duiAnswer;
            duiAnswer = Convert.ToString(Console.ReadLine());
            x = Convert.ToBoolean(duiAnswer);

            Console.WriteLine("How many speeding tickets do you have?");
            int userTickets;
            userTickets = Convert.ToInt32(Console.ReadLine());
            //bool howManyTickets = (userTickets < 3);
            //Console.WriteLine(howManyTickets);

             
            //Console.WriteLine("Qualified?");
            //bool userApproved = (userAge >= 15) && (duiAnswer = false) && (userTickets < 3);
            //Console.WriteLine(userApproved);

            


            Console.ReadLine();
        }
    }
}
