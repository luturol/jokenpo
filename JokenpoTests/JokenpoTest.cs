using Jokenpo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JokenpoTests
{
    [TestClass]
    public class JokenpoTest
    {
        [TestMethod]
        public void Should_be_able_to_rock_win_scissor()
        {
            Assert.IsTrue(new JokenpoJudge().ValidateGame(JokenpoPositions.Rock, JokenpoPositions.Scissor));
        }
    }
}
