User user1 = new User("Adam");
User user2 = new User("Monika","haslo");
User user3 = new User("Zuzia","1234567890","Monika");
User user4 = new User();



class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }

    public User(string login)
    {
        this.login = login;
    }
    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
    }
    public User(string login, string password, string name)
    {
        this.login = login;
        this.password = password;
        this.name = name;
    }
}