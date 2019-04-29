using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char z = 'Z';

            Console.WriteLine(65 - a);
            Console.WriteLine(z - 65);

            //string str = "ABWKDJHGWASSD";
            //string str = "zaaarrubbaz";
            string str = "abcdefghijklmno";

            str = str.ToUpper();

            int [] alphabet = new int[26];
            var firstOccurenceIndex = str.Length - 1;
            var lastOccurenceIndex = 0;
            bool thereWasRepeatedLetter = false;

            for (int i = 0; i < str.Length; i++)
            {
                var letterIndex = str[i] - 65;
                if (alphabet[letterIndex] == 0)
                {
                    alphabet[letterIndex] = str[i];
                }
                else
                {
                    thereWasRepeatedLetter = true;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j] == str[i] && j < firstOccurenceIndex)
                        {
                            firstOccurenceIndex = j;
                            lastOccurenceIndex = i;
                        }
                            
                    }
                }
            }

            if (thereWasRepeatedLetter)
            {
                Console.WriteLine($"\nThe string is: {str}\n");
                Console.WriteLine($"The following letter occured first time in the string: '{str[firstOccurenceIndex]}', its index in the string: {firstOccurenceIndex}");
                Console.WriteLine($"\nSecond occurence in the string index is: {lastOccurenceIndex}");
            }
            else
            {
                Console.WriteLine("Нема...");
            }
            


            Console.ReadLine();
        }
    }
}
