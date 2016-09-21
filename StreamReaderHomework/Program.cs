using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //read and print the first line from the file only
            Console.Write("***Read and print the first line from the file only.***\n\n");
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");

            int lineNum = 1;

            string line = reader.ReadLine();

            for (lineNum = 1; lineNum < 2; lineNum++)
            {
                Console.WriteLine(line);
            }
            Console.Write("\n\n");

            //read and print the entire text file
            Console.Write("***Read and print the entire text file.***\n\n");
            StreamReader reader2 = new StreamReader("..\\..\\..\\Shakespeare.txt");

            string entire = reader2.ReadToEnd();

            Console.WriteLine(entire);
            Console.Write("\n\n");

            //read and print the entire text file and capitalize all lowercase vowels
            Console.Write("***Read and print the entire text file and capitalize all lowercase vowels.***\n\n");
            StreamReader reader3 = new StreamReader("..\\..\\..\\Shakespeare.txt");

            string entireLowerVowels = reader3.ReadToEnd(); 
            
            

            string vowelsToUpper = entireLowerVowels.Replace('a', 'A');
            vowelsToUpper = vowelsToUpper.Replace('e', 'E');
            vowelsToUpper = vowelsToUpper.Replace('i', 'I');
            vowelsToUpper = vowelsToUpper.Replace('o', 'O');
            vowelsToUpper = vowelsToUpper.Replace('u', 'U');

            //anyway to do this with a loop?

            Console.Write(vowelsToUpper + "\n\n");

        }
    }
}
