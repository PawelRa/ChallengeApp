﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            //rzutowanie
            int valueInInt = (int)grade;
            //int valueInInt = (int)Math.Ceiling((grade));
            //int valueInInt = (int)Math.Floor((grade));
            //float f = (float)valueInInt;
            float f = valueInInt;

            if (f >= 0 && f <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            //Parsowanie wartości bez sprawdzenia czy string jest liczbą
            //var value = float.Parse(grade);
            //this.AddGrade(value);

            //Parsowanie wartości wraz ze sprawdzeniem czy string jest liczbą
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else { Console.WriteLine($"Text {grade} is not a number"); }
        }


        public void AddGrade(double grade)
        {
            float floatGrade = Convert.ToSingle(grade);
            this.AddGrade(floatGrade);
        }

        public void AddGrade(long grade)
        {
            float floatGrade = (float)(grade);
            this.AddGrade(floatGrade);
        }

        public void AddGrade(sbyte grade)
        {
            float sbytetGrade = (float)(grade);
            this.AddGrade(sbytetGrade);
        }

        public void AddGrade(short grade)
        {
            float shortGrade = (float)(grade);
            this.AddGrade(shortGrade);
        }



        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            //foreach (var grade in this.grades)
            //{
            //    statistics.Max = Math.Max(statistics.Max, grade);
            //    statistics.Min = Math.Min(statistics.Min, grade);
            //    statistics.Average += grade;
            //}

            var index = 0;
            //do //pętla do - while zawsze wykona się przynajmniej 1x
            //{
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;
            //} while (index < this.grades.Count);

            while (index < this.grades.Count) //pętla while
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } 


            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
