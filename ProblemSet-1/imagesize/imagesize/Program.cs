using System;

namespace imagesize
{
    
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("enter testcase!");
            int testcase=int.Parse(Console.ReadLine());


    



            for (int m = 0; m < testcase; m++)
            {
                Console.WriteLine("enter r!");
                int r= int.Parse(Console.ReadLine());
                char [,] img = new char[r, r];
                Console.WriteLine("enter q!");
                int q = int.Parse(Console.ReadLine());
                char[,] enlarged = new char[q, q];
                if (q % r == 0)

                {
                    for (int g = 0; g < r; g++)
                    {



                        for (int k = 0; k < r; k++)
                        {
                            Console.WriteLine("enter matrix ascii");
                            //Console.WriteLine("arr!" + g +" "+ k);

                            img[g, k] = char.Parse(Console.ReadLine());

                        }
                    }



                    for (int d = 0; d < r; d++)
                    {



                        for (int dk = 0; dk < r; dk++)
                        {
                            Console.WriteLine("enter matrix ascii");
                            Console.WriteLine("arr" + img[d, dk]);

                            //    img[dg, dk] = char.Parse(Console.ReadLine());

                        }
                    }

                    char[,] newImage = new char[q, q];
                    for (int j = 0; j < q; j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            newImage[j, k] = img[j * r / q, k * r / q];
                        }
                    }
                    for (int j = 0; j < q; j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            Console.Write(newImage[j, k] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else


                { Console.WriteLine("Not Possible!"); }
            }
         
        }
    }
}
