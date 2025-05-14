namespace Model_Yourself;

public class User
{
    public string? Name { get; }
    public string? Age { get; }
    public string? Country { get; }
    public string? Hobby { get; }

    public User(string? name, string? age, string? country, string? hobby)
    {
        Name = name;
        Age = age;
        Country = country;
        Hobby = hobby;
    }

    public void Info()
    {
        Console.WriteLine($"Jeg heter {Name} og jeg er {Age} gammel og kommer fra {Country} ");
    }

    public void DoHobby()
    {
        Console.WriteLine($"Jeg er glad i å {Hobby}");
    }
}