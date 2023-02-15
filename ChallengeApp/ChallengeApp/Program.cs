﻿using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("==========================");
Console.WriteLine();

Employee employee = new Employee("Jan", "Nowak");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }


    }
}

Console.WriteLine($"Wyniki pracownika {employee.Name} {employee.Surname}:");
var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Average Letter = {statistics.AverageLetter}");
Console.WriteLine($"Average = {statistics.Average}");
Console.WriteLine($"Min = {statistics.Min}");