using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    public class Working_with_text
    {
        public static void Exercise1()
        {
            Console.WriteLine("Give me a seqence of numbers:");
            var input = Console.ReadLine();
            var numbers = input.Split("-");
            var consecutive = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (Convert.ToInt32(numbers[i]) - Convert.ToInt32(numbers[i + 1]) > 1)
                {
                    consecutive = false;
                    break;
                }
            }

            if (Math.Abs(Convert.ToInt32(numbers[numbers.Length - 1]) - Convert.ToInt32(numbers[0])) != numbers.Length - 1)
                consecutive = false;
            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Non-Consecutive");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Give me a seqence of numbers:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var numbers = input.Split("-");
            var distinct = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!distinct.Contains(Convert.ToInt32(numbers[i])))
                {
                    distinct.Add(Convert.ToInt32(numbers[i]));
                }
                else
                {
                    Console.WriteLine("Duplicate");
                    return;
                }


            }

            Console.WriteLine("No duplicate");
        }
        public static void Exercise3()
        {
            Console.WriteLine("Give me a time:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var numbers = input.Split(":");

            //Check hour
            var hour = Convert.ToInt32(numbers[0]);
            if (hour < 0 || hour >= 24)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            //Check minutes
            var minute = Convert.ToInt32(numbers[1]);
            if (minute < 0 || minute >= 60)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            Console.WriteLine("Ok");
        }

        public static void Exercise4()
        {
            Console.WriteLine("Give me few words:");
            var input = Console.ReadLine().Trim().ToLower();
            
            Console.WriteLine(PascalCaseGenerator(input));
        }

        public static string PascalCaseGenerator(string sentence) 
        {
            var words = sentence.Split(" ");
            var pascalCaseStr = new StringBuilder();

            foreach (var word in words)
            {

                pascalCaseStr.Append(word.Substring(0, 1).ToUpper())
                             .Append(word.Substring(1));
            }
            return pascalCaseStr.ToString();
        }

        public static void Exercise5()
        {
            Console.WriteLine("Give me an English word:");
            var input = Console.ReadLine().ToLower();

            
            Console.WriteLine(CountOfVowels(input));
        }

        public static int CountOfVowels(string word)
        { 
            var vowels = 0;
            foreach (var character in word)
            {
                if (character == 'a' ||
                    character == 'e' ||
                    character == 'o' ||
                    character == 'u' ||
                    character == 'i' )
                    vowels++;

            }
            return vowels;
        }
    }
}
