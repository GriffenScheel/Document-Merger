using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Merger
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Document Merger\n");
            bool go = true;
            while (go == true)
            {

                Console.WriteLine("What is the text file name? Make sure to have .txt at the end.");
                string file1 = Console.ReadLine();
                string filepath = @"C:\Users\Griffen Monster\Desktop\Document Merger\Document Merger\bin\Debug\";
                string file1name = filepath + file1;


                if (File.Exists(file1name))
                {
                    Console.WriteLine("File Exists.");

                    go = false; 

                }
                else
                {
                    Console.WriteLine("File was not found. Re-type name and again make sure .txt is at the end.");
                }
            }

            bool goo = true;
            while (goo == true)
            {

                Console.WriteLine("What is the text file name? Make sure to have .txt at the end.");
                string file2 = Console.ReadLine();
                string filepath2 = @"C:\Users\Griffen Monster\Desktop\Document Merger\Document Merger\bin\Debug\";
                string file2name = filepath2 + file2;


                if (File.Exists(file2name))
                {
                    Console.WriteLine("File Exists.");

                    goo = false;

                }
                else
                {
                    Console.WriteLine("File was not found. Re-type name and again make sure .txt is at the end.");
                }
             
            }



           
            
            Console.ReadKey();

        }
    }
}
