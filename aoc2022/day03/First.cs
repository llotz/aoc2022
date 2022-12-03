using System;
using System.Collections.Generic;

namespace aoc2022.day03
{
    class First
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day03/in.txt");
            int foo = 0;
            List<char> items = new List<char>();

            foreach (string backpack in text)
            {
                string s1 = backpack.Substring(0, backpack.Length / 2);
                string s2 = backpack.Substring(backpack.Length / 2);
                foreach (char c in s1)
                {
                    if (s2.Contains(c))
                    {
                        items.Add(c);
                        break;
                    }
                }
            }

            foreach (char item in items)
            {
                if (((int)item) >= 97)
                {
                    foo += ((int)item) - 96;
                }
                else
                {
                    foo += ((int)item) - 64+26;
                }
            }


            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
