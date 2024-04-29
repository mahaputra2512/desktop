namespace PenjualanProduk
{
    class Produk
    {
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }

        public Produk(string namaProduk, int harga, int stok)
        {
            NamaProduk = namaProduk;
            Harga = harga;
            Stok = stok;
        }
    }
}
