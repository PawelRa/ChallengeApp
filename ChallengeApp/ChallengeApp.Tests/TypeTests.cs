

using NUnit.Framework;


namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void TestObiektu()
        {
            //arrange

            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act


            //assert
            Assert.AreEqual(user1, user2);


        }

        [Test]
        public void TestWartosci()
        {
            //arrange

            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act


            //assert

            Assert.AreEqual(user1.Login, user2.Login);


        }


        private User GetUser(string name)
        {
            return new User(name, "haslo");
        }


    }
}