using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteDrillpg41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (packageWeight <= 50){
                Console.WriteLine("Please enter the package height: ");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package width: ");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if (packageWidth + packageLength + packageHeight > 50)
                {
                    Console.WriteLine("Package is too big to shipped Package Express. Good Bye.");
                }
                else
                {
                    int customerQuote = (packageWidth * packageWidth * packageLength * packageHeight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + customerQuote +);
                }
                
                   
                
            }



            Console.ReadLine();
        }
    }
}
