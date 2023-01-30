namespace ChallengeApp
{
    public class Employee
    {
        private int score = 0;
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int result { get { return score; } }
        public void AddScore(int score)
        {
            this.score += score;
        }
    }
}
