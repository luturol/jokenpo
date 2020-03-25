using System;

namespace Jokenpo
{
    public class Judge
    {
        public bool ValidateGame(Play player1, Play player2)
        {
            return player1.Position.ToRule().WinAgainst(player2.Position);             
        }
    }
}
