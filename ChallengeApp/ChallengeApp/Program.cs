using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak");
Employee employee2 = new Employee("Zenon", "Kowalski");
Employee employee3 = new Employee("Maria", "Wiśniewska");

employee1.AddGrade("2");
employee1.AddGrade(5);
employee1.AddGrade(99f);
employee1.AddGrade(7);
employee1.AddGrade(11);

var statistics = employee1.GetStatisticsWithDoWhile();

Console.WriteLine("Max = " + statistics.Max);

//interpolacja stringów
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine(employee2.Name);