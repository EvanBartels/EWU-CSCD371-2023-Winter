using System.Runtime.InteropServices;

namespace ClassDemo;
public class Program
{
    public static string GetName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }

    static void Main(string[] args)
    {
        string name = "Inigo Montoya";
        Console.WriteLine($"Hello, {name}");
    }

    public static (int, string) ImplicitTypes()    // (int, string) is a tuple
    {
        string text = "You killed my father!"; //when this was var, the data type of this is string
        //var text2 = GetName(); //not obvious, can use var here instead of string, in general use specific type if obvoius
        var text3 = new String('a', 10); //valid to use var
        string text4 = new('a', 10); //can build string like this, in general just don't use var
        return (42, text);

    }
}
