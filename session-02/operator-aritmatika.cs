using System;

public class LuasPersegi {
    public static void Main() 
    {
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

        Console.WriteLine($"Total Nilai adalah : {total}");
        Console.WriteLine($"Rata Rata Nilai adalah : {avg}");
    }
}