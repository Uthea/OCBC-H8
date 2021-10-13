using System;

namespace proUseCase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int num;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. menu pesawat tempur");
                Console.WriteLine("2. menu overloading"); 
                Console.WriteLine("3. menu bilangan");
                Console.WriteLine("4. profile");
                Console.Write("Ketik : ");
                num = int.Parse(Console.ReadLine());

                switch(num)
                {
                    case 1: {
                        pesawat pesawat = new pesawat();
                        pesawat.pesawat_tempur pswttempur = new pesawat.pesawat_tempur(); 

                        Console.WriteLine("Masukan nama pesawat : ");
                        pesawat.Nama = Console.ReadLine();
                        Console.WriteLine("Masukan jumlah roda pesawat : ");
                        pesawat.JumlahRoda = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukan ketinggian pesawat : ");
                        pesawat.ketinggian = Console.ReadLine();
                        Console.WriteLine("Masukan jumlah penumpang pesawat : ");
                        pesawat.JumlahPenumpang = Console.ReadLine();

                        Console.WriteLine("Masukan nama pesawat tempur : ");
                        pswttempur.Nama = Console.ReadLine();
                        Console.WriteLine("Masukan jumlah roda pesawat tempur : ");
                        pswttempur.JumlahRoda = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukan ketinggian pesawat tempur : ");
                        pswttempur.ketinggian = Console.ReadLine();
                        Console.WriteLine("Masukan jumlah penumpang pesawat tempur : ");
                        pswttempur.JumlahPenumpang = Console.ReadLine();

                        // pesawat.Nama = "Helly";
                        // pesawat.JumlahRoda = 3;
                        // pesawat.ketinggian = "1000 kaki";
                        // pesawat.JumlahPenumpang = "3 penumpang";
                        // pswttempur.Nama = "AZ500TPU";
                        // pswttempur.JumlahRoda = 5;
                        // pswttempur.ketinggian = "200 kaki";
                        // pswttempur.JumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

                        pesawat.terbang();
                        Console.WriteLine();
                        pswttempur.terbang();

                        flag = keluar();

                        break;
                    }

                    case 2: {
                        overloading.data datanew = new overloading.data();
                        Console.Write("Masukan nama : ");
                        datanew.print(Console.ReadLine());
                        Console.Write("Masukan nomor hp : ");
                        datanew.print(int.Parse(Console.ReadLine()));
                        // datanew.print("Foxy");
                        // datanew.print(1641231231);

                        flag = keluar();
                        break;
                    }

                    case 3: {
                        Bilangan overiding = new Bilangan();
                        int num1, num2;

                        Console.Write("Masukan bilangan 1 : "); 
                        num1  = int.Parse(Console.ReadLine());
                        Console.Write("Masukan bilangan 2 : "); 
                        num2  = int.Parse(Console.ReadLine());
                         
                        overiding.bilangan(num1, num2);
                        overiding.penjumlahanperkaliandll();                       

                        // overiding.bilangan(10, 5);
                        // overiding.penjumlahanperkaliandll();

                        flag = keluar();
                        break;
                    }

                    case 4: {
                        Console.WriteLine("Pengalaman saya dalam mempelajari C# sampai saat ini cukup menyenangkan dikarenakan syntax nya mirip java.");
                        flag = keluar();
                        break;
                    }
                }

            } while(flag);
            
            
        }


        public static bool keluar()
        {
            string input;
            bool flag = false;

            Console.Write("Kembali ke menu utama ? (y/n) : ");
            input = Console.ReadLine();

            switch(input)
            {
                case "y":
                flag = true;
                break;
            }

            return flag;

        }

    
    }
}
