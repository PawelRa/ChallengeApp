//tablice
int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
//Console.WriteLine(dayOfWeeks[3]);

//deklaracja tablicy wraz z inicjalizacją
string[] weekdays = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedzierla" };
//Console.WriteLine(weekdays[6]);

//pętle
for (int i = 0; i < weekdays.Length; i++)
{
//    Console.WriteLine(weekdays[i]);
}

//Lista
List<string> days = new List<string>();
days.Add("poniedziałek");
days.Add("wtorek2");
days.Add("środa");
days.Add("czwartek");
days.Add("piątek");
days.Add("sobota");
days.Add("niedziela");

for (int i = 0; i < days.Count; i++)
{
    Console.WriteLine(days[i]);
}

Console.WriteLine(days.Count);