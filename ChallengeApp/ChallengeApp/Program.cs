string name;
bool isWomen;
int age;

name = "Ola";
age = 33;
isWomen = true;

if (isWomen)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Jesteś kobietą");
    }
}


else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Jesteś mężczyzną");
    }
}