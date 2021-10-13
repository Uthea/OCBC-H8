using System;

namespace pro4
{
    public class overide:Program
    {
        public override void penjumlahanperkaliandll()
        {
           Console.WriteLine("Overiding 2.....---->>>>");
           Console.WriteLine("Hasil pembagian angka {0} dan angka {1}= {2}", 
                    bilangan1, bilangan2, bilangan1/bilangan2);
           Console.WriteLine("Hasil pengurangan angka {0} dan angka {1}= {2}\n\n", 
                    bilangan1, bilangan2, bilangan1 - bilangan2); 
        }

        public static void Main(string[] args) 
        {
            Program overiding = new Program();
            overiding.bilangan(10, 5);
            overiding.penjumlahanperkaliandll();
            overiding = new overide();
            overiding.bilangan(20, 5);
            overiding.penjumlahanperkaliandll();
            Console.Read();

        }
        
    }
}