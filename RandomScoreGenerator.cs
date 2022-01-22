using System;
using System.Collections.Generic;
using System.Text;

namespace Deserv_TechRound
{
    public static class RandomScoreGenerator
    {
        public static string GetRandomWinner()
        {
            Random random = new System.Random();
            return random.Next(1, 100) % 2 == 0 ? PlayerConstants.PLAYERONE : PlayerConstants.PLAYERTWO;
        }
    }
}
