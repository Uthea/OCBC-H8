using System;

namespace readline
{
    class Program
    {
        static void Main(string[] args)
        {

            string fname, lname;
            int umur;
            DateTime date1;

            Console.Write("enter your first name : ");
            fname = Console.ReadLine();

            Console.Write("enter your lasts name : ");
            lname = Console.ReadLine();

            Console.Write("enter your age : ");
            umur =  int.Parse(Console.ReadLine());

            Console.Write("enter your birth day : "); 
            date1 =  DateTime.Parse(Console.ReadLine());

            Console.WriteLine("your full name is " + fname + " " + lname);
            Console.WriteLine("your age : " + umur);
            Console.WriteLine("your birth day : " + date1);
        }
    }
}
