using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public class RockRules: AbstractRules
    {
        public override GameResult WinAgainst(HandForm oponent)
        {
            if (oponent == HandForm.Paper)
                return GameResult.Lose;
            else if (oponent == HandForm.Scissor)
                return GameResult.Win;
            else
                return GameResult.Tie;
        }
    }

    public class PaperRules : AbstractRules
    {
        public override GameResult WinAgainst(HandForm oponent)
        {
            if (oponent == HandForm.Scissor)
                return GameResult.Lose;
            else if (oponent == HandForm.Rock)
                return GameResult.Win;
            else
                return GameResult.Tie;
        }
    }

    public class ScissorRules : AbstractRules
    {
        public override GameResult WinAgainst(HandForm oponent)
        {
            if (oponent == HandForm.Rock)
                return GameResult.Lose;
            else if (oponent == HandForm.Paper)
                return GameResult.Win;
            else
                return GameResult.Tie;
        }
    }

}
