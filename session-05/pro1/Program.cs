using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Ketik merek: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Ketik ukuran ram: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Ketik ukuran memory: ");
            laptop1.memory = int.Parse(Console.ReadLine());


            Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("\n Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();

        }
    }
}
