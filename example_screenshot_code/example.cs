public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email
    }

    public string Introduce()
    {
        return $"Hi, I'm {name}, {age} years old";
    }

    public void HaveBirthday()
    {
        age++;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void SetEmail(string newEmail)
    {
        if (newEmail.Contains('@'))
        {
            email = newEmail;
        }
    }
}

class Program
{
    static void Main()
    {
        var person = new Person("Alice Smith", 30, "alice@example.com");
        Console.WriteLine(person.Introduce());
        person.HaveBirthday();
        Console.WriteLine(person.Name);
        person.SetEmail("alice.new@example.com");
    }
}
