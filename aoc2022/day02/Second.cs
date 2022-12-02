using System;
using System.Linq;

namespace aoc2022.day02
{
    class Second
    {
        //string[] opponent = new string[] { "A", "B", "C" };
        string[] me = new string[] { "X", "Y", "Z" };

        string[] wins = new string[] { "A Y", "B Z", "C X" };
        string[] draw = new string[] { "A X", "B Y", "C Z" };
        string[] lose = new string[] { "A Z", "B X", "C Y" };

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

            string gameResult = game.Substring(2, 1);
            string opponentsChoice = game.Substring(0, 1);

            if (gameResult == "Y")
            {
                gameScore += 3;
                gameScore += Array.IndexOf(me, draw.First(x => x.StartsWith(opponentsChoice)).Substring(2, 1)) + 1;
            }
            else if (gameResult == "Z")
            {
                gameScore += 6;
                gameScore += Array.IndexOf(me, wins.First(x => x.StartsWith(opponentsChoice)).Substring(2, 1)) + 1;
            }
            else
            {
                gameScore += Array.IndexOf(me, lose.First(x => x.StartsWith(opponentsChoice)).Substring(2, 1)) + 1;
            }




            return gameScore;
        }
    }
}
