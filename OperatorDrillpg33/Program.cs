using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OperatorDrillpg33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication
            Console.WriteLine("Insert a number to multiply by 50");
            string multiInput = Console.ReadLine();            
            int multiply = Convert.ToInt32(multiInput);
            multiply = multiply * 50;
            Console.WriteLine(multiply);            
            //Addition
            Console.WriteLine("Insert a number to add by 25");
            string addInput = Console.ReadLine();
            int add = Convert.ToInt32(addInput);
            add = add + 25;
            Console.WriteLine(add);           
            //Division
            Console.WriteLine("Insert a number to divide by 12.5");
            string divInput = Console.ReadLine();
            double divide = Convert.ToInt32(divInput);
            divide = divide / 12.5;
            Console.WriteLine(divide);           
            //Comparison
            //string comInput = Console.ReadLine();
            //bool compare = Convert.ToBoolean(comInput);
            //bool compare = comInput > 50;
            //Console.ReadLine();
            //Remainder
            Console.WriteLine("Insert a number to divide by 7 and get a remainder");
            string remInput = Console.ReadLine();
            int remainder = Convert.    ToInt32(remInput);
            remainder = remainder % 7;
            Console.WriteLine(remainder);
            Console.Read();  
            

        }
    }
}
