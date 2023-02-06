using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("==========================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika");
var input = Console.ReadLine();
Console.WriteLine(input);

Employee employee = new Employee("Jan", "Nowak");
employee.AddGrade(input);
var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine(statistics.AverageLetter);