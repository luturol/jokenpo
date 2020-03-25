using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public enum Position
    {
        Rock,
        Paper,
        Scissor
    }

    public static class PositionsExtensions
    {
        public static AbstractRules ToRule(this Position positions)
        {
            if (positions == Position.Rock)
                return new RockRules();
            else if (positions == Position.Paper)
                return new PaperRules();
            else if (positions == Position.Scissor)
                return new ScissorRules();
            else
                throw new ArgumentException("There is no position for this option");
        }
    }    
}
