using System;

namespace aoc2022.day04
{
    class Second
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day04/in.txt");
            int foo = 0;

            foreach (string line in text)
            {
                string[] sp = line.Split(',');
                int[] s1 = Array.ConvertAll(sp[0].Split('-'), x => int.Parse(x));
                int[] s2 = Array.ConvertAll(sp[1].Split('-'), x => int.Parse(x));
                if ((s1[0] >= s2[0] && s1[0] <= s2[1]) ||
            (s1[1] >= s2[0] && s1[1] <= s2[1]) ||
            (s2[1] >= s1[0] && s2[1] <= s1[1]) ||
            (s2[0] >= s1[0] && s2[0] <= s1[1]))
                    foo++;
            }

            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
