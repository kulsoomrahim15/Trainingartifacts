using System;

namespace number_prob2
{
    class Program
    {
       public static string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2).ToString() + binary;
                decimalNumber = decimalNumber / 2;
            }
            return binary;
        }
        public static int BinToDec(string binary)
        {
            int decimalValue = 0;
            int power = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power++;
            }
            return decimalValue;
        }


        public static string ConvertBinaryToOctal(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return Convert.ToString(decimalValue, 8);
        }



        public static string Base8ToDecimal(string base8Number)
        {
            int decimalValue = Convert.ToInt32(base8Number, 8);
            return Convert.ToString(decimalValue, 10);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter test case");
            int testcase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcase; i++)
            {


                Console.WriteLine(" source number system");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("target number system");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine(" which needs to convert");
                int z = int.Parse(Console.ReadLine());


// decimal to binary 
if ( x==10 && y==2)
                {
                    string output = DecimalToBinary(z);
                    Console.WriteLine("output {0}", output);

                }
                //binary to  decimal 
                else if (x == 2 && y == 10)
                {
                    int  output = BinToDec(z.ToString());
                    Console.WriteLine("output {0}", output);

                }
                else if (x == 2 && y == 8)
                {
                    string output = ConvertBinaryToOctal(z.ToString());

                    Console.WriteLine("output {0}", output);
                }



                else if (x == 8 && y == 2)


                    //octAL TO binary 

                   // octal to decimal
                {
                    string sub_output = Base8ToDecimal(z.ToString());
                    //decimal to bin
                    string output = DecimalToBinary(int.Parse(sub_output));
                    Console.WriteLine("output {0}", output);
                }



else if (x == 8 && y == 10)
                {

                    string output = Base8ToDecimal(z.ToString());
                    Console.WriteLine("output {0}", output);
                }



                else if (x == 10 && y == 8)
                {
                    //decimal to binary


                    string sub_output = DecimalToBinary(z);
                    //bin to base 8
                    
                    string output = ConvertBinaryToOctal(sub_output);
                    Console.WriteLine("output {0}", output);
                }
            }

        }
    }
}
