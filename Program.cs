using System;

namespace UASKASIR
{
    //Membuat Public Class
    public class kasir
    {
        public void KasirCafe() //Membuat method
        {
            {
                //Menampilkan di output
                Console.WriteLine("=================================================================");
                Console.WriteLine("                    Program Kasir Caffe                          ");
                Console.WriteLine("                        Caffe J.Co                               ");
                Console.WriteLine("=================================================================");
                Console.Write("\n");
                Console.WriteLine(" Silahkan Memilih Item Menu ");
                Console.Write("\n");

                //Menampilkan Menu Minuman
                Console.WriteLine("================Minuman================");
                Console.WriteLine(" 1. Jus Mangga              : Rp 10,000");
                Console.WriteLine(" 2. Jus Lemon               : Rp 10,000");
                Console.WriteLine(" 3. Jus Alpukat             : Rp 10,000");
                Console.WriteLine(" 4. Vietnam Drip            : Rp 15,000");
                Console.WriteLine(" 5. Americano               : Rp 15,000");
                Console.WriteLine(" 6. Espresso                : Rp 15,000");
                Console.Write("\n");

                //Menampilkan Menu Makanan
                Console.WriteLine("================Makanan================");
                Console.WriteLine(" 1. Salad Buah              : Rp 10,000");
                Console.WriteLine(" 2. Kentang Goreng          : Rp 10,000");
                Console.WriteLine(" 3. Spaghetti               : Rp 15,000");
                Console.WriteLine(" 4. Nasi Goreng             : Rp 15,000");
                Console.WriteLine(" 5. Nasi Liwet              : Rp 15,000");
                Console.WriteLine(" 6. Jagung Bakar            : Rp 10,000");
                Console.Write("\n");


                int jumlah; //Deklarasi Variable Jumlah dengan Integer

                //Looping Menginput Jumlah Barang Menggunakan Do While
                do
                {
                    Console.Write("\n Masukkan Jumlah Barang: ");
                    jumlah = int.Parse(Console.ReadLine());

                } while (jumlah <= 0 || jumlah > 200);

                //Mendeklarasikkan Variable Data nama, harga, total, bayar
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

                //Menampilkan Masukkan Nama Pelanggan
                Console.WriteLine("============================");
                Console.Write("Masukkan Nama Pelanggan: ");

                //Deklarasi Variable Data String
                string namap1 = Console.ReadLine();

                //Looping Dengan Kombinasi Array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //Menampilkan Input Nama Barang
                        Console.WriteLine("============================");
                        Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();

                        //User Harus Menginput Nama Barang Diatas 0 sampai 30 Karakter
                    }
                    while (nama[i].Length <= 0 || nama[i].Length >= 30);

                    do
                    {
                        //Menampilkan Input Harga
                        Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());

                        //User Harus Menginput Harga Barang Minimal 5000 Sampai 1000000
                    }
                    while (harga[i] <= 5000 || harga[i] >= 1000000);

                }
                //Menampilkan Barang Dan Harga Yang Sudah Terpilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==============================================================");
                Console.WriteLine("               Daftar Barang Yang Dipilih                     ");
                Console.WriteLine("==============================================================");

                //Membuat variable total harga
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);

                }
                foreach (int i in harga)
                {
                    total += i;
                }



                //Menampilkan Total Harga
                Console.WriteLine("=====================================================");
                Console.WriteLine("Total Harga : Rp" + total);

                //Lopping dengan kombinasi array
                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan Kembalian Uang Dari Uang Yang Dibayar Dikurangi Uang Total
                    kembalian = bayar - total;

                    //Jika Input Uang Yang Dibayarkan Kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uangmu Tidak Cukup");

                    }
                    //Jika Input Uang Yang Dibayarkan Lebih
                    else //Menampilkan Uang Kembali
                    {
                        Console.WriteLine("Uang Kembalian : Rp" + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", namap1.ToString());
                Console.Write("\n");

                //Menampilkan Tanggal Dan Waktu Transaksi
                Console.WriteLine("Tanggal Transaksi :" + DateTime.Today.ToString("yyy-MM-dd"));
                Console.WriteLine("Jam Transaksi :" + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("===============================================================");
                Console.WriteLine("                    Nama Kasir : Richard                       ");
                Console.WriteLine("                        Terima Kasih                           ");
                Console.WriteLine("===============================================================");

                //Mencetak Nota Dengan Streamwiritter
                using (StreamWriter sw = new StreamWriter(@"C:\Users\LENOVO\Nota.txt")) //Lokasi File Nota Dicetak
                {
                    sw.WriteLine("+================================================================+");
                    sw.WriteLine("                           Caffe J.Co                             ");
                    sw.WriteLine("+====================== NOTA PEMBAYARAN =========================+");
                    sw.WriteLine("                    Nama Barang Yang Dibeli                       ");
                    //Mendeklarasikan jumlah,nama dan harga
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("+================================================================+");
                    sw.WriteLine("Total Harga          : Rp" + total);
                    sw.WriteLine("Tunai                : Rp" + bayar);
                    sw.WriteLine("Kembalian            : Rp" + kembalian);
                    sw.WriteLine("\n");

                    //Menampilkan Nama Pelanggan
                    sw.WriteLine("Nama Pelanggan: {0}", namap1.ToString());

                    //Menampilkan Tanggal Dan Waktu Transaksi
                    sw.WriteLine("Tanggal Transaksi :" + DateTime.Today.ToString("yyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi :" + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("+=================================================================+");
                    sw.WriteLine("                      Nama Kasir : Richard                         ");
                    sw.WriteLine("                         Terima Kasih                              ");
                    sw.WriteLine("+=================================================================+");
                    Console.Write("\n");
                    Console.WriteLine("Nota Telah Diprint");

                }
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER Untuk Keluar");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //Memanggil Class Kasir Caffe
            kasir kasirC = new kasir();
            kasirC.KasirCafe();
        }
    }
}

