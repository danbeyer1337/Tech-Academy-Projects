using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");

            //Question 1
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are on course:" + yourCourse);

            //Question 2
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You are on page number " + pageNumber);

            //Question 3
            Console.WriteLine("Do you need any help with anything? Please answer \"true\" or \"false\".");
            bool x = true;
            string needHelp = Console.ReadLine();
            Console.WriteLine(Convert.ToBoolean(needHelp));
            if (x == true)
            {
                Console.WriteLine("We can help! What do you need help with?");
            }
            else
            {
                Console.WriteLine("Let us know if you need anything!");
            }
            Console.ReadLine();
            //Question 4
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specfics.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback.");

            //Question 5
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack1 = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback.");

            //Question 6
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Good job on studying" + hours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");


            Console.ReadLine();
        }
    }
}
