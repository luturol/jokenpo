using System;

namespace Jokenpo
{
    public class JokenpoJudge
    {
        public bool ValidateGame(JokenpoPositions player1, JokenpoPositions player2)
        {
            if (player1 == JokenpoPositions.Rock && player2 == JokenpoPositions.Scissor)
                return true;
            else
                return false;
        }
    }
}
