using FP.ClassInduk;
using System;
using System.Collections.Generic;
using System.Text;

namespace FP.ClassAnak
{
    public class MahasiswaBiasa : Mahasiswa
    {
        public override string Nama { get; set; }
        public override int Nisn { get; set; }
        public override string Asal { get; set; }
        public override int Nohp { get; set; }
        public double Biaya { get; set; }

        public override double TotalBiaya()
        {
            return Biaya;
        }

    }
}