using ChallengeApp;

namespace EmployessTests
{
    public class Tests
    {
        [Test]
        public void WhenUserHasNoPoints_Return0()
        {
            //arrange
            var employess = new Employee("Jan", "Nowak", 25);

            //act
            var result = employess.result;

            //assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenUserAddPoints_ShouldReturnCorrectSum()
        {
            //arrange
            var employess = new Employee("Jan", "Nowak", 25);
            employess.AddScore(3);
            employess.AddScore(5);

            //act
            var result = employess.result;

            //assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void WhenUserLostPoints_ShouldReturnCorrectSum()
        {
            //arrange
            var employess = new Employee("Jan", "Nowak", 25);
            employess.AddScore(3);
            employess.AddScore(5);
            employess.AddScore(-30);

            //act
            var result = employess.result;

            //assert
            Assert.AreEqual(-22, result);
        }
    }
}