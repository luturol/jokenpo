using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public class RockRules: AbstractRules
    {
        public override GameStatus WinAgainst(Position oponent)
        {
            if (oponent == Position.Paper)
                return GameStatus.Lose;
            else if (oponent == Position.Scissor)
                return GameStatus.Win;
            else
                return GameStatus.Tie;
        }
    }

    public class PaperRules : AbstractRules
    {
        public override GameStatus WinAgainst(Position oponent)
        {
            if (oponent == Position.Scissor)
                return GameStatus.Lose;
            else if (oponent == Position.Rock)
                return GameStatus.Win;
            else
                return GameStatus.Tie;
        }
    }

    public class ScissorRules : AbstractRules
    {
        public override GameStatus WinAgainst(Position oponent)
        {
            if (oponent == Position.Rock)
                return GameStatus.Lose;
            else if (oponent == Position.Paper)
                return GameStatus.Win;
            else
                return GameStatus.Tie;
        }
    }

}
