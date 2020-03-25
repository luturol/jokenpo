using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public abstract class AbstractRules
    {
        public abstract GameStatus WinAgainst(Position oponent);
    }
}
