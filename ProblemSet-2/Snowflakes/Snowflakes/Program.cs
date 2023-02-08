using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowflakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Testcase!");
            int testcase = int.Parse(Console.ReadLine());



            for (int i = 0; i < testcase; i++)
            {

                Console.WriteLine("Enter number of snowflakes!");

                int snowflakes_no = int.Parse(Console.ReadLine());

                IDictionary<int, int> snowflakes = new Dictionary<int, int>();


                for (int j = 0; j < snowflakes_no; j++)
                {


                    int snowflake_value = int.Parse(Console.ReadLine());
                    snowflakes[j] = snowflake_value;

                }

                //creating a list of ditint values 
                var distinctList = snowflakes.Values.Distinct().ToList();
                int count = distinctList.Count();

                Console.WriteLine("Distint snowflakes {0}", count);

            }
        }
    }
}
