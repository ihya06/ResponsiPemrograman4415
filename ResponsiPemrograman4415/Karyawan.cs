using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4415
{
    internal class Karyawan
    {
        public string Nomor { get; set; }
        public string Nama { get; set; }
        public float GajiRutin { get; set; }
        public Karyawan(string nomor, string nama, float gaji)
        {
            this.Nomor = nomor;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.GajiRutin = gaji;
        }

        public void GajiNaik(float upah)
        {
            this.GajiRutin = upah / 100 * this.GajiRutin + this.GajiRutin;
        }
    }
}
