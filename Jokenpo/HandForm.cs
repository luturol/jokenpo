using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public enum HandForm
    {
        Rock,
        Paper,
        Scissor
    }

    public static class HandFormExtensions
    {
        public static AbstractRules ToRule(this HandForm handForm)
        {
            if (handForm == HandForm.Rock)
                return new RockRules();
            else if (handForm == HandForm.Paper)
                return new PaperRules();
            else if (handForm == HandForm.Scissor)
                return new ScissorRules();
            else
                throw new ArgumentException("There is no hand form rule for this option");
        }
    }    
}
