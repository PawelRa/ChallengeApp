namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name)
            : this(name, "anonymous", 'M')
        {
            this.Name = name;
        }

        public Person(string name, string surname)
            : this(name, surname, 'M')
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name, string surname, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
    }
}
