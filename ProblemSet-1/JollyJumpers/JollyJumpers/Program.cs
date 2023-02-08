using System;

namespace JollyJumpers
{
//    If absolute difference between two elements is more than n-1 or 0, return false. 
//If an absolute difference repeated, then all absolute differences from 1 to n-1 can’t be present(Pigeon Hole Principle), return false.
    class Program
    {

       static bool JollyorNot(int n, int[] seq)
        {
            Boolean[] diffSet = new Boolean[n];

            //int[] seq = new int[n];
            //Boolean[] diffSet = new Boolean[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    seq[i] = Convert.ToInt32(Console.ReadLine());
            //}

            for (int i = 0; i < n - 1; i++)
            {

                int d = Math.Abs(seq[i] - seq[i + 1]);
           //     if ((seq[i] - seq[i + 1] >1) || (seq[i] - seq[i + 1] < (n - 1)) || diffSet[d] == true)
           if(d>(n-1)|| d==0|| diffSet[d] == true)
                {
                    return false;
                }

                    diffSet[d] = true;
 
            }
            return true;
        }


            public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N!");
            n= Convert.ToInt32(Console.ReadLine());


            int[] seq = new int[n];
      
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                seq[i] = Convert.ToInt32(Console.ReadLine());
            }

            if ((JollyorNot(n,seq))==true)
            {

                Console.WriteLine("Jolly");

            }

            else
            {
                Console.WriteLine(" Not Jolly");


            }


        }
    }
}
