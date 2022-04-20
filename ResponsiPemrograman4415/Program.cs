using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4415
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan("21114415", "Ihya", 5000000);
            Karyawan kar2 = new Karyawan("21114499", "Udin", 7000000);
            Console.WriteLine("Program Gaji Bulanan Karyawan Ternak Kode");
            Console.WriteLine("No   Nomor/Nama        Gaji Setiap Bulan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.Nomor, kar1.Nama, kar1.GajiRutin);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.Nomor, kar2.Nama, kar2.GajiRutin);

            Console.WriteLine();
            Console.WriteLine("Alhamdulillah Gaji Naik 10%");
            Console.WriteLine();

            kar1.GajiNaik(10);
            kar2.GajiNaik(10);

            Console.WriteLine("No   Nomor/Nama        Gaji Setiap Bulan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.Nomor, kar1.Nama, kar1.GajiRutin);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.Nomor, kar2.Nama, kar2.GajiRutin);

            Console.ReadKey();
        }
    }
}
