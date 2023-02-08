using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;



//Problem1
namespace Egypt
{
    class Program
    {



        static void Main(string[] args)
        {
            string line;

           


            int a, b, c;
            while (true)
            {
               

                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());



                if (a + b + c == 0)
                 break; 



                if ((a*a == b * b + c * c)||(c * c == b * b + a * a) ||(b * b == a * a + c * c))
                    Console.WriteLine("Right");

                else

                    Console.WriteLine("Wrong");
            } 
        }



    }
    }


