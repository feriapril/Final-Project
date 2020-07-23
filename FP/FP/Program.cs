using FP.ClassInduk;
using FP.ClassAnak;
using System;



using System.Collections.Generic;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<MahasiswaBiasa> mahasiswaBiasas = new List<MahasiswaBiasa>();
            List<MahasiswaInternasional> mahasiswaInternasionals = new List<MahasiswaInternasional>();
            Console.Title = "Aplikasi Daftar Universitas";
        menu:
            Console.WriteLine("MENU UTAMA");
            Console.WriteLine("Daftar Universitas");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Masukan Data Mahasiswa");
            Console.WriteLine("2. Lihat Data Mahasiswa");
            Console.WriteLine("3. Hapus Data Mahasiswa");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("=====================");
            Console.Write("Masukkan pilihan 1-4 : ");
            
            int pil;
            int pil2;

            pil = int.Parse(Console.ReadLine());
            if (pil == 1)
            {
                Console.WriteLine("1. Daftar Mahasiswa Biasa");
                Console.WriteLine("2. Daftar Mahasiswa Internasional ");
                Console.Write("Masukkan pilihan 1-2: ");
                pil2 = int.Parse(Console.ReadLine());

                if (pil2 == 1)
                {
                    string asal, nama;
                    int nisn, nohp;
                    double biaya;
                    Console.Write("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.Write("Masukan Nisn : ");
                    nisn = int.Parse (Console.ReadLine());
                    Console.Write("Masukan Asal : ");
                    asal = Console.ReadLine();
                    Console.Write("Masukan No HP : ");
                    nohp = int.Parse(Console.ReadLine());
                    Console.Write("Masukan DP Biaya : ");
                    biaya = int.Parse(Console.ReadLine());
                    mahasiswaBiasas.Add(new MahasiswaBiasa() { Nisn = nisn, Nama = nama, Asal = asal, Nohp = nohp, Biaya = biaya });
                }
                else if (pil2 == 2)
                {
                    string asal, nama;
                    int nisn, nohp;
                    double biaya;
                    Console.Write("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.Write("Masukan Nisn : ");
                    nisn = int.Parse(Console.ReadLine());
                    Console.Write("Masukan Asal : ");
                    asal = Console.ReadLine();
                    Console.Write("Masukan No HP : ");
                    nohp = int.Parse(Console.ReadLine());
                    Console.Write("Masukan DP Biaya : ");
                    biaya = int.Parse(Console.ReadLine());
                    mahasiswaInternasionals.Add(new MahasiswaInternasional() { Nisn = nisn, Nama = nama, Asal = asal, Nohp = nohp, Biaya = biaya });
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pil == 2)
            {
                Console.WriteLine("List Data Mahasiswa");
                int no = 1;
                foreach (Mahasiswa mahasiswa in mahasiswaBiasas)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Mahasiswa Biasa, {4}",
                    no, mahasiswa.Nisn, mahasiswa.Nama, mahasiswa.Asal, mahasiswa.Nohp, mahasiswa.TotalBiaya());
                    no++;
                }
                foreach (Mahasiswa mahasiswa in mahasiswaInternasionals)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Mahasiswa Internasional, {4}",
                    no, mahasiswa.Nisn, mahasiswa.Nama, mahasiswa.Asal, mahasiswa.Nohp, mahasiswa.TotalBiaya());
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }
            else if (pil == 3)
            {
                Console.WriteLine("Pilihan Hapus Mahasiswa");
                int hapus;
                bool Ga = false;
                Console.WriteLine("Masukan Nisn : ");
                hapus = int.Parse(Console.ReadLine());
                int x = 0;
                foreach (Mahasiswa mahasiswa in mahasiswaBiasas)
                {
                    if (hapus == mahasiswa.Nisn)
                    {
                        Ga = true;
                        break;
                    }
                    x++;
                    if (Ga)
                    {
                        mahasiswaBiasas.RemoveAt(x);
                        Console.WriteLine("Data Berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Data Tidak Ditemukan");
                    }
                }
                x = 0;
                foreach (Mahasiswa mahasiswa in mahasiswaInternasionals)
                {
                    if (hapus == mahasiswa.Nisn)
                    {
                        Ga = true;
                        break;
                    }
                    x++;
                    if (Ga)
                    {
                        mahasiswaInternasionals.RemoveAt(x);
                        Console.WriteLine("Data Berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Data Tidak Ditemukan");
                    }
                }
                x = 0;
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else
            {
                Console.WriteLine("Terimakasih telah menggunakan Aplikasi ini");
            }
            Console.ReadKey(true);
            Console.Clear();

        }
    }
}