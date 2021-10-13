using System;

namespace pro2
{
    public class Pesawat
    {
        public string nama;
        private string _ketinggian;
        public string ketinggian
        {
            get {return _ketinggian;}
            set {_ketinggian = value;}
        }

        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
        }

        public void sudahTerbang()
        {
            Console.WriteLine("Pesaswat sekarang berada pada ketinggian {0}", this.ketinggian);
        }
    }
}