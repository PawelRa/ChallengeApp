using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak");
Employee employee2 = new Employee("Zenon", "Kowalski");
Employee employee3 = new Employee("Maria", "Wiśniewska");

employee1.AddGrade(2);
employee1.AddGrade(5);
employee1.AddGrade(7);

var statistics = employee1.GetStatistics();

Console.WriteLine("Max = " + statistics.Max);

//interpolacja stringów
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");