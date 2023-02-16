using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class SupervisiorTests
    {
        [Test]
        public void SupervisiorMinMaxAverageTest()
        {
            //arrange
            Supervisior supervisior = new Supervisior ("Helena", "Kowalska");

            //act
            supervisior.AddGrade("6");
            supervisior.AddGrade("5");
            supervisior.AddGrade("4");
            supervisior.AddGrade("3");
            supervisior.AddGrade("2");
            supervisior.AddGrade("1");

            var result = supervisior.GetStatisticsWithForEach();

            //assert
            Assert.That(result.Max, Is.EqualTo(100));
            Assert.That(result.Average, Is.EqualTo(50));
            Assert.That(result.Min, Is.EqualTo(0));
        }

        [Test]
        public void SupervisiorPlusMinusTest()
        {
            //arrange
            Supervisior supervisior = new Supervisior("Helena", "Kowalska");

            //act
            supervisior.AddGrade("5");
            supervisior.AddGrade("1");
            supervisior.AddGrade("3-");
            supervisior.AddGrade("3");
            supervisior.AddGrade("+3");
            supervisior.AddGrade("-2");
            supervisior.AddGrade("+2");
            supervisior.AddGrade("4");

            var result = supervisior.GetStatisticsWithForEach();

            //assert
            Assert.That(result.Max, Is.EqualTo(80));
            Assert.That(result.Average, Is.EqualTo(37.5));
            Assert.That(result.Min, Is.EqualTo(0));
        }

        [Test]
        public void SupervisiorNoGradeTest()
        {
            //arrange
            Supervisior supervisior = new Supervisior("Helena", "Kowalska");

            //act
            var noGradeResult = supervisior.GetStatisticsWithForEach();

            //assert            
            Assert.AreEqual(noGradeResult.Average, float.NaN);
        }
    }
}
