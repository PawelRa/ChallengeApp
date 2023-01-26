//var myAge = 33;
//int notMyAge = 33;

//int myAge = int.MaxValue;
//int myAge = int.MinValue;

//liczby całkowite
using System.Net.NetworkInformation;

int myAge = 120;
int newAge = myAge + 5;
//Console.WriteLine(newAge);

int myVar = -2;
uint myVar2 = uint.MaxValue;
uint myVar3 = uint.MinValue;

long myVar4 = long.MaxValue;
long myVar5 = long.MinValue;

ulong myVar6 = ulong.MaxValue;
ulong myVar7 = ulong.MinValue;

//liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
float Mynumber2 = float.MinValue;

double myNumber3 = double.MaxValue;
double myNumber4 = double.MinValue;

decimal myNumber5 = decimal.MaxValue;
decimal myNumber6 = decimal.MinValue;

//zmienne tekstowe
string name = "Adam";
string surname = "nazwisko nieznane";
string result = name + " " + surname;
//Console.WriteLine(result);

char myVar8 = 'A';

var charResult = name.ToArray();
//Console.WriteLine(charResult);
//.WriteLine(charResult.Length);


//zmienna logiczna
bool isActive = true;
isActive = false;

var isVaild = 5 > 6;
//Console.WriteLine(isVaild);

var number1 = 5;
var number2 = 10;

//operatory relacyjne
// ==
// !=
// <
// >
// <=
// >=

if (number1 > number2)
{
    Console.WriteLine("Jestem tutaj");
}
else
{
    Console.WriteLine("Warunek nie jest spełniony");
}

//operatory logiczne
// && - i
// || - lub
// ! - negacja

if (name == "Adam" && myAge < 150)
{
    Console.WriteLine("Adam żyje");
}

if (name == "Stefan" || myAge < 150)
{
    Console.WriteLine("Test przeszedł");
}



if (!isActive)
{
    Console.WriteLine("Jest aktywny " + isActive);
}
else
{
    Console.WriteLine("Nieaktywny");
}


if (name == "Stefan")
{
    Console.WriteLine("Jesteś Stefanem");

}
else if (name == "Adam")
{
    Console.WriteLine("Jesteś Adamem");
    if (myAge >= 18)
    {
        Console.WriteLine("Jesteś osobą pełnoletnią");
    }
}