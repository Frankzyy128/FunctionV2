using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoingLunch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What main dish would you like?");
            string mainCourse;
            mainCourse = Console.ReadLine();
            Console.WriteLine("Hello, your Lunch is " + mainCourse);
            Console.WriteLine("Hello, your lunch is {0}", mainCourse);
            Console.WriteLine("How many roast potatoes?");
            string sRoasties;
            sRoasties = Console.ReadLine();
            int roastCount;
            roastCount = Convert.ToInt32(sRoasties);
            Console.WriteLine("Hello your lunch is " + mainCourse + " with " + roastCount + " roast potatoes ");
      
           
            //Console.WriteLine("How many brussel sprouts?");


            // Put the display here!

        }

    }
}