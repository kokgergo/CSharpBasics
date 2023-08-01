using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    public class Lists_and_arrays
    {
        public static void Exercise1()
        {
            var names = new List<string>();
            Console.Write("Give me names: ");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                    break;
                names.Add(input);
            }
            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0}, {1} like your post", names[0], names[1]);
                    break;

                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.Write("Give me your name: ");
            var name = Console.ReadLine();
            var namearr = new char[name.Length];

            for (int i = name.Length; i > 0; i--)
            {
                namearr[name.Length - i] = name[i - 1];
            }

            var reversedName = new string(namearr);


            Console.WriteLine(reversedName);

        }

        public static void Exercise3()
        {
            Console.Write("Give me 5 unique nubmers: ");
            const int CountOfNumbers = 5;
            var numbers = new int[CountOfNumbers];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    var input = Console.ReadLine();
                    var number = Convert.ToInt32(input);
                    if (Array.IndexOf(numbers, number) == -1)
                    {
                        numbers[i] = number;
                        break;
                    }
                    Console.WriteLine("Provide unique number please!");

                }
            }
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.Write("{0}, ", number);
        }

        public static void Exercise4()
        {
            var numbers = new List<int>();
            Console.WriteLine("Give me numbers or \"Quit\"");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var uniqueElements = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueElements.Contains(number))
                {
                    uniqueElements.Add(number);
                }
            }

            foreach (var number in uniqueElements)
                Console.WriteLine(number);
        }

        public static void Exercise5()
        {
            var numbers = new List<int>();
            Console.WriteLine("Give me numbers: ");
            var input = Console.ReadLine();
            var inputNumber = input.Split(",");
            if (inputNumber.Length < 5)
            {
                Console.WriteLine("Invalid list");
                return;
            }
            foreach (var str in inputNumber)
                numbers.Add(int.Parse(str));
            numbers.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
