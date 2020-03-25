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
            var result = new Judge().ValidateGame(new Play() { Position = Position.Rock }, new Play() { Position = Position.Scissor });
            Assert.IsTrue(result);
        }
    }
}
