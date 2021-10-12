using System;
public class LuasPersegi {
    public static void Main() 
    {
        bool married;
        int age;
        string password, username, gender;

        Console.Write("Username : ");
        username = Console.ReadLine();
        Console.Write("Password : ");
        password = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Gender (laki-laki / perempuan): ");
        gender = Console.ReadLine();
        Console.Write("Married (true / false): ");
        married = Boolean.Parse(Console.ReadLine()); 

        if(gender != "laki-laki" && gender != "perempuan")
        {
            gender = "salah input";
        }

        if (password == "OCBC" && age > 18)
        {
            Console.WriteLine("WELCOME TO THE CLUB!");
            double num1, num2, num3;
            double total, avg;
            Console.WriteLine("===Menghitung Nilai===");
            Console.Write("Masukan nilai PERTAMA: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KEDUA: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KETIGA: "); 
            num3 = double.Parse(Console.ReadLine());

            total = num1 + num2 + num3;
            avg = total / 3;

            Console.WriteLine("=== BIODATA==");
            Console.WriteLine("Umur : " + age);
            Console.WriteLine("username : " + username);
            Console.WriteLine("gender : " + gender);
            Console.WriteLine("married : " + married);

            Console.WriteLine("===Aritmatika===");
            Console.WriteLine($"Total Nilai adalah : {total}");
            Console.WriteLine($"Rata Rata Nilai adalah : {avg}"); 
        }
        else 
        {
            Console.WriteLine("Sorry, try again!");
        }

    }
}