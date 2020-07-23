namespace FP.ClassInduk
{
    public abstract class Mahasiswa
    {
        public abstract string Nama { get; set; }
        public abstract int Nisn { get; set; }
        public abstract string Asal { get; set; }
        public abstract int Nohp { get; set; }
        public abstract double TotalBiaya();
    }
}
