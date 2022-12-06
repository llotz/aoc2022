using System;
using System.Collections.Generic;
using System.Linq;

namespace aoc2022.day05
{
    class First
    {
        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day05/in.txt");
            int foo = 0;

            Dictionary<int, List<char>> container = new Dictionary<int, List<char>>();
            for (int i = 0; i <= 9; i++)
            {
                container[i] = text[i].ToCharArray().ToList();
            }

            for (int i = 10; i < text.Length; i++)
            {
                string[] f = text[i].Split(' ');
                int amount = Convert.ToInt32(f[1]);
                int source = Convert.ToInt32(f[3]) - 1;
                int target = Convert.ToInt32(f[5]) - 1;

                List<char> chunk = container[source].Take(amount).ToList();
                container[source].RemoveRange(0, amount);
                //chunk.Reverse();
                container[target].InsertRange(0, chunk);
            }

            foreach (List<char> c in container.Values)
            {
                if (c.Count > 0)
                    Console.Write(c[0]);
            }




            Console.WriteLine(foo);
            Console.ReadLine();
        }
    }
}
