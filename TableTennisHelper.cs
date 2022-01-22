using System;
using System.Collections.Generic;
using System.Text;

namespace Deserv_TechRound
{
    public class TableTennisHelper
    {
        public static void Play(Player playerOne, Player playerTwo)
        {
            string player = RandomScoreGenerator.GetRandomWinner();
            playerOne.ScoreCard.Add(player == PlayerConstants.PLAYERONE);
            playerTwo.ScoreCard.Add(player == PlayerConstants.PLAYERTWO);
            if (playerOne.IsServeLeft)
            {
                playerOne.NumberOfServes--;
                playerTwo.NumberOfServes = playerOne.NumberOfServes == 0 ? 2 : playerTwo.NumberOfServes;
            }
            else
            {
                playerTwo.NumberOfServes--;
                playerOne.NumberOfServes = playerTwo.NumberOfServes == 0 ? 2 : playerOne.NumberOfServes;
            }
        }
    }
}
