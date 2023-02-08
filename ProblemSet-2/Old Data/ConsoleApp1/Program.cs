using System;
using System.IO;
using System.Text.RegularExpressions;



//Problem1
namespace ReadATextFile
{
    class Program
    {
        // Default folder    
        static readonly string rootFolder = @"E:\Temp\Data\";    
  //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
  static readonly string textFile = @"E:\Temp\Data\text.txt";

        static void Main(string[] args)
        {
      

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                int recordcount=0;
                bool isRecord;
                bool result;
                string code;
                foreach (string line in lines)
                {

                    Console.WriteLine(line);
          //saving each line txt file  
                    code = line;


        //
                    int i = 0;
                    Console.WriteLine(code);
                    //while (code[i] != " ")

                    String[] spearator = { " " };
                    Int32 count = 100; //max substring count

                    // using the method to seprate each word to test if its a record
                    String[] strlist = code.Split(spearator, count,
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (String s in strlist)
                    {
                        Console.WriteLine(s);


                        isRecord=Regex.IsMatch(s, @"^\d+$");
                      

                        int len = s.Length;
                        //counting record on the basis of criteria shared 
                        if ((isRecord == true)&& (len==6))
                        {
                            recordcount++;
                        }

                            Console.WriteLine(isRecord);
                    }



              







                }

                Console.WriteLine(recordcount);



            }

      
            Console.ReadKey();

       


        }

          

          
        }
    }

