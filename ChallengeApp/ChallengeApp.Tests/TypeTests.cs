using NUnit.Framework;
namespace ChallengeApp.Tests

{
    public class TypeTests
    {
        [Test]
        public void IntValueVariableTest()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;

            //act
            int result = number1 + number2;

            //assert
            Assert.AreEqual(4, result);
            Assert.AreEqual((int)number1, number2);
        }

        [Test]
        public void DoubleValueVariableTest()
        {
            //arrange
            double number1 = 1.654879658465;
            double number2 = 1.654879658465;

            //act
            double result = number1 + number2 + 1;

            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number1 + number2 + 1, result);
        }


        [Test]
        public void BoolValueVariableTest()
        {
            //arrange
            bool number1 = true;
            bool number2 = false;

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void StringTest()
        {
            //arrange
            string text1 = "Ola ma kota";
            string text2 = "Ola ma kota";

            //assert
            Assert.AreEqual(text1, text2);
        }


        [Test]
        public void ReferenceVariableTests()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreEqual((user1.Login, user1.Password), (user2.Login, user2.Password));
        }

        private User GetUser(string name)
        {
            return new User(name, "haslo");
        }
    }
}