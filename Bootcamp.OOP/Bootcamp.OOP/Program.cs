using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World");
            //Console.Read();
            Bangun2D panggil;
            Console.WriteLine("=======Perhitungan Luas=======");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("==============================");
            Console.Write("Masukkan pilihan anda : ");
            char x = Convert.ToChar(Console.ReadLine());
            switch (x)
            {
                case '1':
                    Console.WriteLine("==============================");
                    Console.WriteLine("Pilihan anda adalah " + x);
                    Console.Write("Masukkan besar jari-jari : ");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    panggil = new HitungLuasLingkaran(jari);
                    panggil.CetakLuas("Lingkaran");
                    break;

                case '2':
                    Console.WriteLine("==============================");
                    Console.WriteLine("Pilihan anda adalah " + x);
                    Console.Write("Masukkan Besar Alas : ");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Besar Tinggi : ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    panggil = new HitungLuasSegitiga(alas, tinggi);
                    panggil.CetakLuas("Segitiga");
                    break;

                case '3':
                    Console.WriteLine("==============================");
                    Console.WriteLine("Pilihan anda adalah " + x);
                    Console.Write("Masukkan besar sisi : ");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    panggil = new HitungLuasPersegi(sisi);
                    panggil.CetakLuas("Persegi");
                    break;

                case '4':
                    Console.WriteLine("==============================");
                    Console.WriteLine("Pilihan anda adalah " + x);
                    Console.Write("Masukkan Besar Panjang : ");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Besar Lebar : ");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    panggil = new HitungLuasPersegiPanjang(panjang, lebar);
                    panggil.CetakLuas("Persegi Panjang");
                    break;

                default:
                    Console.WriteLine("==============================");
                    Console.WriteLine("Your choice is not found, try again later, good boi XD");
                    break;
            }
            Console.Read();
        }
    }
}
