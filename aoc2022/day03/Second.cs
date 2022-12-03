using System;
using System.Collections.Generic;

namespace aoc2022.day03
{
    class Second
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day03/in.txt");
            int foo = 0;
            List<char> items = new List<char>();

            for (int i = 0; i < text.Length; i+=3)
            {
                foreach (char c in text[i])
                {
                    if (text[i+1].Contains(c) && text[i+2].Contains(c))
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
                    foo += ((int)item) - 64 + 26;
                }
            }



            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
