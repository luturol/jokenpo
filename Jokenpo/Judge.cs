using System;

namespace Jokenpo
{
    public class Judge
    {
        public GameResult ValidateGame(Player player1, Player player2)
        {
            return player1.HandForm.ToRule().WinAgainst(player2.HandForm);             
        }
    }
}
