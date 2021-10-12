using System;

public class Data2 {
    public static void Main () {
        string[] contoh = new string[]
        {
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilan semua data array");
        Console.WriteLine("");

        foreach(string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }

        Console.Write("Press any key to continue ...");
        Console.ReadLine();

    }
}