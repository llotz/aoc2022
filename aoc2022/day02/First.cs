using System;

namespace aoc2022.day02
{
    class First
    {
        //string[] opponent = new string[] { "A", "B", "C" };
        string[] me = new string[] { "X", "Y", "Z" };

        string[] wins = new string[] { "A Y", "B Z", "C X" };
        string[] draw = new string[] { "A X", "B Y", "C Z" };

        public void Run()
        {
            string[] text = System.IO.File.ReadAllLines(@"day2/in.txt");
            int foo = 0;
            for (int i = 0; i < text.Length; i++)
            {
                foo += GetGameScore(text[i]);
            }

            Console.WriteLine(foo);
            Console.ReadLine();
        }

        public int GetGameScore(string game)
        {
            int gameScore = 0;

            if (Array.IndexOf(wins, game) >= 0) gameScore += 6;
            else if (Array.IndexOf(draw, game) >= 0) gameScore += 3;
            else gameScore += 0;

            string myChoice = game.Substring(2, 1);
            gameScore += Array.IndexOf(me, myChoice) + 1;

            return gameScore;
        }
    }
}
