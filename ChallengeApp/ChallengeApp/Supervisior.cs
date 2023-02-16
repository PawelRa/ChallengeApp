namespace ChallengeApp
{
    public class Supervisior : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisior(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($" {grade} is invalid value. Correct values 0-100");
            }
        }

        public void AddGrade(double grade)
        {
            float floatGrade = Convert.ToSingle(grade);
            this.AddGrade(floatGrade);
        }


        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("There is a wrong letter");
            }
        }


        public float SwitchGrade(string gradeValue)
        {
            switch (gradeValue)
            {
                case "6":
                    return 100;

                case "5":
                    return 80;

                case "4":
                    return 60;

                case "3+":
                case "+3":
                    return 45;

                case "3":
                    return 40;

                case "-3":
                case "3-":
                    return 35;

                case "2+":
                case "+2":
                    return 25;

                case "2":
                    return 20;

                case "-2":
                case "2-":
                    return 15;

                case "1":
                    return 0;

                default:
                    throw new Exception($"Rating in SWitchGrade {gradeValue} is out of range");
            }
        }

        public void AddGrade(string grade)
        {
            this.AddGrade(SwitchGrade(grade));
        }


        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
