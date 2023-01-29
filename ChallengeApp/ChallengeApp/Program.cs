﻿using System.Threading.Tasks.Sources;

User user1 = new User("Adam", "sgksdkjg354");
User user2 = new User("Monika", "haslo");
User user3 = new User("Zuzia", "1234567890");
User user4 = new User("Damian", "32423fddf");

//user1.Login = "Marek";
Console.WriteLine(user2.Login);
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);

Console.WriteLine(User.GameName);
var pi = Math.PI;

class User
{
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();


    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }


    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}