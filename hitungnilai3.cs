using System;
public class LuasPersegi {
    public static void Main() 
    {
        int nilai1, nilai2;

        Console.Write("jumlah nilai1 = ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("jumlah nilai2 = ");
        nilai2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Hasil perbandingan");
        Console.WriteLine($"nilai1 > nilai2 : {nilai1 > nilai2}");
        Console.WriteLine($"nilai1 >= nilai2 : {nilai1 >= nilai2}");
        Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");
        Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}");
    }
}