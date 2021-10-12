using System;

public class Logika2
{
    public static void Main() 
    {
        int nilai;
        string nama;

        Console.Write("Enter your name :");
        nama = Console.ReadLine();
        Console.Write("Enter your number :");
        nilai = int.Parse(Console.ReadLine());



        Console.WriteLine("Nama : " + nama);

        if (nilai < 60) {
            Console.WriteLine("Nilai Kamu C");
        } else if (nilai < 80) {
            Console.WriteLine("Nilai Kamu B");
        } else {
            Console.WriteLine("Nilai Kamu B");
        }

        // switch (nilai) 
        // {
        //     case  < 60:
        //         Console.WriteLine("Nilai Kamu C");
        //         break;
        //     case  < 80:
        //         Console.WriteLine("Nilai Kamu B");
        //         break;
        //     default: 
        //         Console.WriteLine("Nilai Kamu B");
        //         break; 
        // }

    }
}