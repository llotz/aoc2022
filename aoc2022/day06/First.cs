using System;
using System.Linq;

namespace aoc2022.day06
{
    class First
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day06/in.txt");
            int foo = 0;

            for (int i = 13; i < text[0].Length; i++)
            {
                var values = new[] { text[0][i - 13], text[0][i - 12], text[0][i - 11], text[0][i - 10], text[0][i - 9], text[0][i - 8], text[0][i - 7], text[0][i - 6], text[0][i - 5], text[0][i - 4], text[0][i - 3], text[0][i - 2], text[0][i - 1], text[0][i] };
                if (!values.Any(x => values.Count(y => x == y) > 1))
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }

            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
