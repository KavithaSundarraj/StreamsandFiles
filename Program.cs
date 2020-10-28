using System;
using System.IO;
using System.Text;
/*
Exercises C# Streams and Files - Line Numbers
Program that reads a text file and inserts line numbers in front of each of its lines. 
The result should be written to another text file. 
Use StreamReader in combination with StreamWriter.

Date: 28/10/2020
*/
namespace StreamsandFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input file path
            string pathinput = Directory.GetCurrentDirectory() + @"\text.txt";
            //Output file path
            String pathoutput = Directory.GetCurrentDirectory() + @"\output.txt";

            StreamReader sr1 = File.OpenText(pathinput);
            string s = "";
            int counter = 1;
            
            while ((s = sr1.ReadLine()) != null)
            {
                var lineOutput = "Line " + counter++ + ":" + s;
                
                using (StreamWriter sr = File.AppendText(pathoutput))
                {
                    sr.WriteLine(lineOutput);
                    sr.Close();   
                }

            }
            sr1.Close();
            Console.WriteLine("Finished writing output file.");    
        }
    }
}
