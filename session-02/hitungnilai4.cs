using System;
public class LuasPersegi {
    public static void Main() 
    {
        int age;
        string password;

        Console.Write("Password : ");
        password = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (password == "OCBC" && age > 18)
        {
            Console.WriteLine("WELCOME TO THE CLUB!");
        }
        else 
        {
            Console.WriteLine("Sorry, try again!");
        }

    }
}