User user1 = new User("Adam", "sgksdkjg354");
User user2 = new User("Monika", "haslo");
User user3 = new User("Zuzia", "1234567890", "Monika");
User user4 = new User("Damian", "32423fddf");

//user1.Login = "Marek";
Console.WriteLine(user2.Login);

class User
{
    private string name;

    public User()
    {
        this.Login = "-";
        this.Password = "-";
        this.Name = "-";
    }

    public User(string login)
    {
        this.Login = login;
    }
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public User(string login, string password, string name)
    {
        this.Login = login;
        this.Password = password;
        this.Name = name;
    }

    public string Login { get;private set; }
    public string Password { get; private set; }
    public string Name { get; private set; }
}