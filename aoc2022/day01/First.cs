using System;
using System.Collections.Generic;
using System.Linq;

namespace aoc2022.day01
{
    class First
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day1/in.txt");
            int counter = 0;
            List<int> elves = new List<int>();
            foreach (string line in text)
            {
                if (line == "") counter++;
                else
                {
                    if (counter + 1 > elves.Count)
                        elves.Add(Convert.ToInt32(line));
                    else elves[counter] = elves[counter] + Convert.ToInt32(line);
                }
            }

            int foo = elves.Max();
            elves.Remove(elves.Max());
            foo += elves.Max();
            elves.Remove(elves.Max());
            foo += elves.Max();
            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
