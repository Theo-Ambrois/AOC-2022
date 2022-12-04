using System.Runtime.CompilerServices;

namespace AOC2
{
    public class AOC2
    {
        enum Responses
        {
            A = 1,
            B = 2,
            C = 3
        }

        public int CalculateScoreMax()
        {
            int score = 0;
            foreach (string line in File.ReadLines(@"D:\AoC\AOC-2022\AOC\AOC2\input.txt"))
            {
                string Me;
                string Opponent;
                char[] ch = line.Replace(" ", "").ToCharArray();
                Opponent = ch[0].ToString();
                Me = ch[1].ToString();
                score += ChooseSign(Me, Opponent);

            }
            Console.WriteLine(score.ToString());
            return score;
        }


        public int ChooseWinner(string player1, string player2) {
            int scoreWin = 0;
            if (player1 == "X")
            {
                if(player2 == "A")
                {
                    scoreWin = 3;
                }
                else if (player2 == "C")
                {
                    scoreWin = 6;
                }
                scoreWin = scoreWin + 1;
            }
            if (player1 == "Y")
            {
                if (player2 == "A")
                {
                    scoreWin = 6;
                }
                else if (player2 == "B")
                {
                    scoreWin = 3;
                }
                scoreWin = scoreWin + 2;
            }
            if (player1 == "Z")
            {
                if (player2 == "B")
                {
                    scoreWin = 6;
                }
                else if (player2 == "C")
                {
                    scoreWin = 3;
                }
                scoreWin = scoreWin + 3;
            }
            return scoreWin;
        }

        public int ChooseSign(string end, string player2)
        {
            int score = 0;
            if (end == "X") //Loose
            {
                if (player2 == "A") //Rock
                {
                    score = 3;
                }
                else if (player2 == "B") //Papier
                {
                    score = 1;
                }
                else if (player2 == "C") //Ciseaux
                {
                    score = 2;
                }
                score = score + 0;
            }
            if (end == "Y") //Draw
            {
                if (player2 == "A") //Rock
                {
                    score = 1;
                }
                else if (player2 == "B") //Papier
                {
                    score = 2;
                }
                else if (player2 == "C") //Ciseaux
                {
                    score = 3;
                }
                score = score + 3;
            }
            if (end == "Z") //Win
            {
                if (player2 == "A") //Rock
                {
                    score = 2;
                }
                else if (player2 == "B") //Papier
                {
                    score = 3;
                }
                else if (player2 == "C") //Ciseaux
                {
                    score = 1;
                }
                score = score + 6;
            }
            return score;
        }
    }
}