using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public class RockRules: AbstractValidation
    {
        public override bool WinAgainst(Position oponent)
        {
            if(oponent == Position.Paper)
                return false;
            else
                return true;
        }
    }

    public class PaperRules : AbstractValidation
    {
        public override bool WinAgainst(Position oponent)
        {
            if (oponent == Position.Scissor)
                return false;
            else
                return true;
        }
    }

    public class ScissorRules : AbstractValidation
    {
        public override bool WinAgainst(Position oponent)
        {
            if (oponent == Position.Rock)
                return false;
            else
                return true;
        }
    }

}
