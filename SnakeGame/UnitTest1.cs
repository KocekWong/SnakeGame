using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeGame;

namespace ExampleApplicationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void gameLiveafterLevelUp()
        {
            Program snake = new Program();
            
            snake.Initialization();
            bool ExpectedGameLive = snake.getGameLive();
            bool ActualGameLive = true;
            Assert.AreEqual(ExpectedGameLive, ActualGameLive, "Check the Initial Game Situation");


            int ExpectedLevel = 1;
            int ActualLevel = snake.getLevel();
            Assert.AreEqual(ExpectedLevel, ActualLevel, "Check the Level at the Start of the Game");


            int testingpts = 2;
            snake.SetScore(testingpts);

            snake.Logic();
            int ExpectedLevel2 = 2;
            int ActualLevel2 = snake.getLevel();
            Assert.AreEqual(ExpectedLevel2, ActualLevel2, "Check whether the Level Up occured");


            bool ExpectedGameLive2 = snake.getGameLive();
            bool ActualGameLive2 = true;
            Assert.AreEqual(ExpectedGameLive2, ActualGameLive2, "Check whether the Game is still running");
        }

        [TestMethod]
        public void testSnakeLength()
        {
            Program snake = new Program();
            //snake and food position
            int x = 1;
            int foodx = 2;
            int y = 2;
            int foody = 2;
            snake.SetX(x);
            snake.SetY(y);
            snake.SetFoodX(foodx);
            snake.SetFoodY(foody);

            snake.Initialization();
            int ExpectedTailNumber = 2;
            int ActualTailNumber = snake.getTail();
            Assert.AreEqual(ExpectedTailNumber, ActualTailNumber, "Check the Initial Tail Length");

            int dx = 1;
            int dy = 0;
            snake.SetDX(dx);
            snake.SetDY(dy);
            snake.SetX(x);
            snake.SetY(y);
            snake.SetFoodX(foodx);
            snake.SetFoodY(foody);

            snake.Logic();
            int ExpectedTailNumber1 = 3;
            int ActualTailNumber1 = snake.getTail();
            Assert.AreEqual(ExpectedTailNumber1, ActualTailNumber1, "Check the Added Tail Length");
        }

        [TestMethod]
        public void testheartcount()
        {
            Program snake = new Program();

            snake.Initialization();
            int ExpectedHeart = 0;
            int ActualHeart = snake.getHeart();
            Assert.AreEqual(ExpectedHeart, ActualHeart, "Check the number of Heart is given at the start of the game");

            int testnum = 1;
            snake.SetHeartCount(testnum);

            snake.Logic();
            int ExpectedHeart2 = 1;
            int ActualHeart2 = snake.getHeart();
            Assert.AreEqual(ExpectedHeart2, ActualHeart2, "Check the number of Heart is given after eating the heart shape food");

        }
    }
}
