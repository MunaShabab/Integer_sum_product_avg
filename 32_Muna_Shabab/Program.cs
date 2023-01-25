// chapter 3 Exercise 32
//written by Muna Shabab
//date: 9-10-2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize32
{
    class Program
    {
        static void Main(string[] args)
        {
            //description of the application
            Console.WriteLine("This application will accept three integers from the user and display their sum, average, \n" +
                "product, smallest, and largest number");

            //declare the variables
            int integer1, integer2, integer3, sum, product, smallest, largest;
            double average;

            //get the integers from the user
            Console.WriteLine("please enter the first integer:");
            integer1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second integer:");
            integer2 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the third integer:");
            integer3 = int.Parse(Console.ReadLine());

            //perform the calculations
            sum = integer1 + integer2 + integer3;
            product = integer1 * integer2 * integer3;

            //find out the smallest numbers
            smallest = integer1;

            if(integer2<smallest)
            {
                smallest = integer2;
            }

            if (integer3<smallest)
            {
                smallest = integer3;
            }

            //find the largest number
            largest = integer1;
            if(integer2>largest)
            {
                largest = integer2;
            }
            if(integer3>largest)
            {
                largest = integer3;
            }
   
            average = (double)(integer1 + integer2 + integer3) / 3;

            //display the results
            Console.WriteLine($"the sum of {integer1:n0} and {integer2:n0} and {integer3:n3} is {sum:n0}");
            Console.WriteLine($"the product of {integer1:n0} and {integer2:n0} and {integer3:n0} is {product:n0}");
            Console.WriteLine($"the smallest of {integer1:n0} and {integer2:n0} and {integer3:n0} is {smallest:n0}");
            Console.WriteLine($"the largest of {integer1:n0} and {integer2:n0} and {integer3:n0} is {largest:n0}");
            Console.WriteLine($"the avarage of {integer1:n0} and {integer2:n0} and {integer3:n0} is {average:n3}");

            Console.ReadLine();

        }
    }
}
