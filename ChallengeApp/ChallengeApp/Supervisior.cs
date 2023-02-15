namespace ChallengeApp
{
    internal class Supervisior : IEmployee
    {
        public string Name => "Adam";

        public string Surname => throw new NotImplementedException();

        public Statistics GetStatisticsWithForEach()
        {
            //throw new NotImplementedException();
            return new Statistics();
        }
    }
}
