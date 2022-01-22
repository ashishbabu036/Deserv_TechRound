using System;

namespace Deserv_TechRound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Game");
            Console.WriteLine("--------------------------------------------");

            Player playerOne = new Player();
            playerOne.Name = PlayerConstants.PLAYERONE;
            Player playerTwo = new Player();
            playerTwo.Name = PlayerConstants.PLAYERTWO;

            Console.Write("Serve Won By :");

            #region TossToDecideServe
            if (RandomScoreGenerator.GetRandomWinner() == PlayerConstants.PLAYERONE)
                playerOne.NumberOfServes = 2;
            else
                playerTwo.NumberOfServes = 2;
            #endregion

            Console.Write(playerOne.IsServeLeft ? PlayerConstants.PLAYERONE : PlayerConstants.PLAYERTWO);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Game Started :");

            #region Play
            while (playerOne.HasPlayerWon == false && playerTwo.HasPlayerWon == false)
            {
                TableTennisHelper.Play(playerOne, playerTwo);
            }
            #endregion

            Console.WriteLine("Game Finished");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Printing ScoreCard");

            int gameRound = playerOne.ScoreCard.Count;
            string scoreCardPlayerA = string.Empty;
            string scoreCardPlayerB = string.Empty;

            #region Scorecard
            foreach (var score in playerOne.ScoreCard)
            {
                scoreCardPlayerA += score ? "WON  " : "LOSS ";
                scoreCardPlayerB += score ? "LOSS " : "WON  ";
            }
            #endregion

            Console.WriteLine("Player One : " + scoreCardPlayerA);
            Console.WriteLine("Player One : " + scoreCardPlayerB);
            Console.WriteLine("Player One : " + playerOne.Score + " Player Two : " + playerTwo.Score);
            Console.WriteLine("Game Won By : " + (playerOne.HasPlayerWon ? PlayerConstants.PLAYERONE : PlayerConstants.PLAYERTWO));
            Console.Read();
        }

        
    }
}
