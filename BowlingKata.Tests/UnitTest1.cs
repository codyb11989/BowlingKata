using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKata.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitialRoll()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);

            //Assert
            Assert.AreEqual(game1.PinsKnockedDown, 1);
        }

        [TestMethod]
        public void InitialScore()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            int tempScore = game1.Score();

            //Assert
            Assert.AreEqual(0, tempScore);
        }

        [TestMethod]
        public void MultipleRolls()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);
            int tempScore = game1.Score();

            //Assert
            Assert.AreEqual(2, tempScore);
        }

        [TestMethod]
        public void Frames()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
        }

        [TestMethod]
        public void TwoFrames()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);
            game1.Roll(2);
            game1.Roll(3);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(5, game1.Frames[1]);
        }

        [TestMethod]
        public void TenFrames()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(5, game1.Frames[1]);
            Assert.AreEqual(5, game1.Frames[2]);
            Assert.AreEqual(5, game1.Frames[3]);
            Assert.AreEqual(5, game1.Frames[4]);
            Assert.AreEqual(5, game1.Frames[5]);
            Assert.AreEqual(5, game1.Frames[6]);
            Assert.AreEqual(5, game1.Frames[7]);
            Assert.AreEqual(5, game1.Frames[8]);
            Assert.AreEqual(5, game1.Frames[9]);
        }

        [TestMethod]
        public void GameOver()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            //Assert
            Assert.IsTrue(game1.GameOver);
        }

        [TestMethod]
        public void Strike()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);
            game1.Roll(10);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(10, game1.Frames[1]);
        }

        [TestMethod]
        public void SpareWith10()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);
            game1.Roll(0);
            game1.Roll(10);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(10, game1.Frames[1]);
        }

        [TestMethod]
        public void Spare()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);
            game1.Roll(1);
            game1.Roll(9);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(10, game1.Frames[1]);
        }

        [TestMethod]
        public void ScoreSpares()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(1);
            game1.Roll(1);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(8);

            game1.Roll(6);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(3);
            game1.Roll(7);

            game1.Roll(5);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(10, game1.Frames[1]);
        }

        [TestMethod]
        public void ScoreStrikes()
        {
            //Arrange
            Game game1 = new Game();

            //Act
            game1.Roll(10);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(8);

            game1.Roll(10);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            game1.Roll(10);

            game1.Roll(3);
            game1.Roll(7);

            game1.Roll(5);
            game1.Roll(3);

            game1.Roll(2);
            game1.Roll(3);

            //Assert
            Assert.AreEqual(2, game1.Frames[0]);
            Assert.AreEqual(10, game1.Frames[1]);
        }
    }
}
