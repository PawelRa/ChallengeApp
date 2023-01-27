//Ilość cyfr w liczbie

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] numberOfNumbers = new int[10];

foreach (char letter in letters)
{
    if (letter == '1') { numberOfNumbers[1]++; }
    else if (letter == '2') { numberOfNumbers[2]++; }
    else if (letter == '3') { numberOfNumbers[3]++; }
    else if (letter == '4') { numberOfNumbers[4]++; }
    else if (letter == '5') { numberOfNumbers[5]++; }
    else if (letter == '6') { numberOfNumbers[6]++; }
    else if (letter == '7') { numberOfNumbers[7]++; }
    else if (letter == '8') { numberOfNumbers[8]++; }
    else if (letter == '9') { numberOfNumbers[9]++; }
    else { numberOfNumbers[0]++; }
}

for (int i = 0; i < numberOfNumbers.Length; i++)
{
    Console.WriteLine(i + " => " + numberOfNumbers[i]);
}
