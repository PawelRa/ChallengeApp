using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("==========================");
Console.WriteLine("Wyjście z programu - q; Dodaj oceny pracownika - p; Dodaj oceny kierownika - s; Zmiana wyboru - z");
Console.WriteLine();

Employee employee = new Employee("Jan", "Nowak");
Supervisior supervisior = new Supervisior("Helena", "Kowalska");

Console.WriteLine("Wybierz pracownika lub kierownika: ");
var input = Console.ReadLine();
while (true)
{
    if (input == "p")
    {
        Console.WriteLine("Podaj ocenę pracownika: ");
        try
        {
            var valueInput = Console.ReadLine();
            if (valueInput == "z")
            {
                Console.WriteLine("Wybierz pracownika lub kierownika: ");
                input = Console.ReadLine();
                continue;
            }
            if (valueInput == "q")
            {
                break;
            }
            employee.AddGrade(valueInput);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    else if (input == "s")
    {
        Console.WriteLine("Podaj ocenę kierownika: ");
        try
        {
            var valueInput = Console.ReadLine();
            if (valueInput == "z")
            {
                Console.WriteLine("Wybierz pracownika lub kierownika: ");
                input = Console.ReadLine();
                continue;
            }
            if (valueInput == "q")
            {
                break;
            }
            supervisior.AddGrade(valueInput);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("OCENY KOŃCOWE");
Console.WriteLine($"Wyniki pracownika {employee.Name} {employee.Surname}:");
var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Average Letter = {statistics.AverageLetter}");
Console.WriteLine($"Average = {statistics.Average}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();
Console.WriteLine($"Wyniki Kierownika {supervisior.Name} {supervisior.Surname}:");
var supervisiorStatistics = supervisior.GetStatisticsWithForEach();
Console.WriteLine($"Max = {supervisiorStatistics.Max}");
Console.WriteLine($"Average Letter = {supervisiorStatistics.AverageLetter}");
Console.WriteLine($"Average = {supervisiorStatistics.Average}");
Console.WriteLine($"Min = {supervisiorStatistics.Min}");