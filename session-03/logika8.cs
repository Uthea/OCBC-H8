using System;

public class Logika8
{
    public static void Main() 
    {
        int max, init, second;
        string op;

        Console.Write("Max iter : ");
        max = int.Parse(Console.ReadLine());
        Console.Write("Initial number : ");
        init = int.Parse(Console.ReadLine());
        Console.Write("Second Number : ");
        second = int.Parse(Console.ReadLine());
        Console.Write("Operation : ");
        op = Console.ReadLine();

        for (int i = 0; i < max; i++)
        {
            switch(op)
            {
                case "plus" : {
                    Console.WriteLine(String.Format("i = {0} output {1}", i, init));
                    init += second;
                    break;}
                case "minus" : {
                    Console.WriteLine(String.Format("i = {0} output {1}", i, init));
                    init -= second;
                    break;}
                case "multiplication" :{
                    Console.WriteLine(String.Format("i = {0} output {1}", i, init));
                    init *= second;
                    break;}
                case "divide" :{
                    Console.WriteLine(String.Format("i = {0} output {1}", i, init));
                    init /= second;
                    break;}
            }
        }

    }
}