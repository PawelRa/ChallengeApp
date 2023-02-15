namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        Statistics GetStatisticsWithForEach();
    }
}
