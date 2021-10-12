using System;

public class Logika4
{
    public static void Main() 
    {
        string username, password;
        int nilai;

        Console.Write("Username : ");
        username = Console.ReadLine(); 
        Console.Write("Password : ");
        password = Console.ReadLine(); 

        if(username == "ocbc" && password == "bootcamp")
        {
            Console.WriteLine("Anda berhasil login");

            Console.Write("Input nilai : ");
            nilai = int.Parse(Console.ReadLine()); 

            if (nilai >= 85)
            {
                Console.WriteLine("Kamu mendapat grade A");
            }
            else if (nilai >= 65)
            {
                Console.WriteLine("Kamu mendapat grade B");
            }
            else if (nilai >= 45)
            {
                Console.WriteLine("Kamu mendapat grade C");
            }
            else if (nilai >= 25)
            { 
                Console.WriteLine("Kamu mendapat grade D");
            }

        }
        else 
        { 
            Console.WriteLine("Username atau Password anda salah");
        }


    }
}