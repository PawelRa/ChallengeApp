using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumOperation()
        {
            //arrange
            int age1 = 10; 
            int age2 = 20;

            //act
            int result = age1 + age2;

            //assert
            Assert.AreEqual(30, result);

        }
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectSum()
        {
            //arrange
            var user = new User("Monika", "haslo");
            user.AddScore(3);
            user.AddScore(5);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(8, result);

        }
    }
}