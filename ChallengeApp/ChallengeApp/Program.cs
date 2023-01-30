using ChallengeApp;
using System.Threading.Tasks.Sources;

User user1 = new User("Adam", "sgksdkjg354");
User user2 = new User("Monika", "haslo");
User user3 = new User("Zuzia", "1234567890");
User user4 = new User("Damian", "32423fddf");

//user1.Login = "Marek";
//Console.WriteLine(user2.Login);
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
//Console.WriteLine(result);

//Console.WriteLine(User.GameName);
var pi = Math.PI;

Employee employee1 = new Employee("Jan", "Nowak", 25);
Employee employee2 = new Employee("Zenon", "Kowalski", 38);
Employee employee3 = new Employee("Maria", "Wiśniewska", 24);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(5);
employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(10);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);

int[] scores = new int[] { employee1.result, employee2.result, employee3.result };
int max = 0;

for (int i = 1; i < scores.Length; i++)
{
    if (scores[i] > scores[i - 1])
    {
        max = i;
    }
}

if (max == 0)
{
    Console.WriteLine(employee1.Name + " " + employee1.Surname + " is a winner and has " + employee1.result + " points");
}
else if (max == 1)
{
    Console.WriteLine(employee2.Name + " " + employee2.Surname + " is a winner and has " + employee2.result + " points");
}
else
{
    Console.WriteLine(employee3.Name + " " + employee3.Surname + " is a winner and has " + employee3.result + " points");
}
