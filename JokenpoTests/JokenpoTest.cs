using Jokenpo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JokenpoTests
{
    [TestClass]
    public class JokenpoTest
    {
        #region Rock Tests
        [TestMethod]
        public void Should_be_able_to_rock_win_scissor()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Rock }, new Play() { Position = Position.Scissor });
            Assert.IsTrue(result == GameStatus.Win);
        }

        [TestMethod]
        public void Should_be_able_to_rock_lose_paper()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Rock }, new Play() { Position = Position.Paper });
            Assert.IsTrue(result == GameStatus.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_rock_tie_rock()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Rock }, new Play() { Position = Position.Rock });
            Assert.IsTrue(result == GameStatus.Tie);
        }
        #endregion

        #region Paper Tests
        [TestMethod]
        public void Should_be_able_to_paper_win_rock()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Paper }, new Play() { Position = Position.Rock });
            Assert.IsTrue(result == GameStatus.Win);
        }

        [TestMethod]
        public void Should_be_able_to_paper_lose_scissor()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Paper }, new Play() { Position = Position.Scissor });
            Assert.IsTrue(result == GameStatus.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_paper_tie_paper()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Paper }, new Play() { Position = Position.Paper });
            Assert.IsTrue(result == GameStatus.Tie);
        }
        #endregion

        #region Scissor Tests
        [TestMethod]
        public void Should_be_able_to_scissor_win_paper()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Scissor }, new Play() { Position = Position.Paper });
            Assert.IsTrue(result == GameStatus.Win);
        }

        [TestMethod]
        public void Should_be_able_to_scissor_lose_rock()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Scissor }, new Play() { Position = Position.Rock });
            Assert.IsTrue(result == GameStatus.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_scissor_tie_scissor()
        {
            GameStatus result = new Judge().ValidateGame(new Play() { Position = Position.Scissor }, new Play() { Position = Position.Scissor });
            Assert.IsTrue(result == GameStatus.Tie);
        }
        #endregion
    }
}
