using System;

public class User
{
    public string Login { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public DateTime RegistrationDate { get; private set; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now; // Ініціалізація дати при створенні
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Registration Date: {RegistrationDate.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter login: ");
        string login = Console.ReadLine();
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);
        user.DisplayUserInfo();
    }
}
