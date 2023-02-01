using ChallengeApp;

User user1 = new User("Adam", "sgksdkjg354");
User user2 = new User("Monika", "haslo");
User user3 = new User("Zuzia", "1234567890");
User user4 = new User("Damian", "32423fddf");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;

var pi = Math.PI;

Employee employee1 = new Employee("Jan", "Nowak", 25);
Employee employee2 = new Employee("Zenon", "Kowalski", 38);
Employee employee3 = new Employee("Maria", "Wiśniewska", 24);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(400);
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