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
        public static AbstractValidation ToRule(this Position positions)
        {
            if (positions == Position.Rock)
                return new RockRules();
            else if (positions == Position.Paper)
                return new PaperRules();
            else if (positions == Position.Scissor)
                return new ScissorRules();
            else
                throw new Exception("not yet implemented");
        }
    }    
}
