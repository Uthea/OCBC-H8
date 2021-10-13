using System;

namespace proUseCase
{
    public class pesawat
    {

        public string Nama;
        public int JumlahRoda;

        public string ketinggian;
        public string JumlahPenumpang;

        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} Akan terbang", this.Nama, this.JumlahRoda, this.ketinggian, this.JumlahPenumpang);
        }

       public class pesawat_tempur:pesawat 
       {
           public void terbang()
           {
               Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} Akan meledakan senjata", this.Nama, this.JumlahRoda, this.ketinggian, this.JumlahPenumpang);
           }
       }
    }
}