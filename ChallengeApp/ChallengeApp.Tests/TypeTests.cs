

using NUnit.Framework;


namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void TEST()
        {
            //arrange

            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            //act


            //assert

        }
        private User GetUser(string name)
        {
            return new User(name, "haslo");
        }


    }
}