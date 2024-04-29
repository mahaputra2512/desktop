

namespace PenjualanProduk
{
    class Login
    {
        private const string Username = "admin";
        private const string Password = "1234";

        public bool PeriksaLogin()
        {
            Console.WriteLine("Masukkan username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Masukkan password:");
            string inputPassword = Console.ReadLine();

            return (inputUsername == Username && inputPassword == Password);
        }
    }
}
