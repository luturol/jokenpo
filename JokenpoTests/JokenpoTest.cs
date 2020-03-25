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
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Rock }, new Player() { HandForm = HandForm.Scissor });
            Assert.IsTrue(result == GameResult.Win);
        }

        [TestMethod]
        public void Should_be_able_to_rock_lose_paper()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Rock }, new Player() { HandForm = HandForm.Paper });
            Assert.IsTrue(result == GameResult.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_rock_tie_rock()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Rock }, new Player() { HandForm = HandForm.Rock });
            Assert.IsTrue(result == GameResult.Tie);
        }
        #endregion

        #region Paper Tests
        [TestMethod]
        public void Should_be_able_to_paper_win_rock()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Paper }, new Player() { HandForm = HandForm.Rock });
            Assert.IsTrue(result == GameResult.Win);
        }

        [TestMethod]
        public void Should_be_able_to_paper_lose_scissor()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Paper }, new Player() { HandForm = HandForm.Scissor });
            Assert.IsTrue(result == GameResult.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_paper_tie_paper()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Paper }, new Player() { HandForm = HandForm.Paper });
            Assert.IsTrue(result == GameResult.Tie);
        }
        #endregion

        #region Scissor Tests
        [TestMethod]
        public void Should_be_able_to_scissor_win_paper()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Scissor }, new Player() { HandForm = HandForm.Paper });
            Assert.IsTrue(result == GameResult.Win);
        }

        [TestMethod]
        public void Should_be_able_to_scissor_lose_rock()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Scissor }, new Player() { HandForm = HandForm.Rock });
            Assert.IsTrue(result == GameResult.Lose);
        }

        [TestMethod]
        public void Should_be_able_to_scissor_tie_scissor()
        {
            GameResult result = new Judge().ValidateGame(new Player() { HandForm = HandForm.Scissor }, new Player() { HandForm = HandForm.Scissor });
            Assert.IsTrue(result == GameResult.Tie);
        }
        #endregion
    }
}
