

namespace PenjualanProduk
{
    class MenuUtama
    {
        private List<Produk> daftarProduk = new()
        {
            new Produk("Mie Goreng", 5000, 10),
            new Produk("Nasi Goreng", 10000, 5),
            new Produk("Ayam Goreng", 15000, 7)
        };

        public void TampilkanMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n===== Menu =====");
                Console.WriteLine("1. Cari Produk");
                Console.WriteLine("2. Sortir Produk");
                Console.WriteLine("3. Tambah Produk");
                Console.WriteLine("4. Hapus Produk");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        CariProduk();
                        break;

                    case 2:
                        SortirProduk();
                        break;

                    case 3:
                        TambahProduk();
                        break;

                    case 4:
                        HapusProduk();
                        break;

                    case 5:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Menu tidak valid.");
                        break;
                }
            }
        }

        private void CariProduk()
        {
            Console.WriteLine("\n===== Cari Produk =====");
            Console.Write("Masukkan nama produk: ");
            string keyword = Console.ReadLine();
            var hasilCari = daftarProduk.Where(p => p.NamaProduk.ToLower().Contains(keyword.ToLower())).ToList();
            if (hasilCari.Count > 0)
            {
                foreach (var produk in hasilCari)
                {
                    Console.WriteLine($"Nama: {produk.NamaProduk}, Harga: {produk.Harga}, Stok: {produk.Stok}");
                }
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan.");
            }
        }

        private void SortirProduk()
        {
            Console.WriteLine("\n===== Sortir Produk =====");
            var produkSortir = daftarProduk.OrderBy(p => p.Stok).ToList();
            foreach (var produk in produkSortir)
            {
                Console.WriteLine($"Nama: {produk.NamaProduk}, Harga: {produk.Harga}, Stok: {produk.Stok}");
            }
        }

        private void TambahProduk()
        {
            Console.WriteLine("\n===== Tambah Produk =====");
            Console.Write("Masukkan nama produk: ");
            string namaBaru = Console.ReadLine();
            Console.Write("Masukkan harga produk: ");
            int hargaBaru = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan stok produk: ");
            int stokBaru = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(new Produk(namaBaru, hargaBaru, stokBaru));
            Console.WriteLine("Produk berhasil ditambahkan.");
        }

        private void HapusProduk()
        {
            Console.WriteLine("\n===== Hapus Produk =====");
            Console.Write("Masukkan nama produk yang ingin dihapus: ");
            string namaHapus = Console.ReadLine();
            var produkHapus = daftarProduk.SingleOrDefault(p => p.NamaProduk.ToLower() == namaHapus.ToLower());
            if (produkHapus != null)
            {
                daftarProduk.Remove(produkHapus);
                Console.WriteLine("Produk berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan.");
            }
        }
    }
}
