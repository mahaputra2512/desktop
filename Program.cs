using System;

namespace PenjualanProduk
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new();
            MenuUtama menuUtama = new();

            if (login.PeriksaLogin())
            {
                menuUtama.TampilkanMenu();
            }
            else
            {
                Console.WriteLine("Username atau password salah.");
            }
        }
    }
}
