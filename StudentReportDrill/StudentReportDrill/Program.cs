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
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You are on page number " + pageNumber);

            //Question 3
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needHelp = true;
            if (needHelp)
            {
                Console.WriteLine("You do not need help.");
            }
            else
            {
                Console.WriteLine("What do you need help with?");
            }
            


            Console.ReadLine();
        }
    }
}
