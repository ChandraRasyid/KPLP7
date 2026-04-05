namespace tpmodul7_kelompok_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hasil Deserialisasi Data Mahasiswa : ");
            DataMahasiswa_103082400003 dm = new DataMahasiswa_103082400003();
            dm.ReadJSON();

            Console.WriteLine("");

            Console.WriteLine("Hasil Deserialisasi Kuliah Mahasiswa : ");
            KuliahMahasiswa_103082400003 km = new KuliahMahasiswa_103082400003();
            km.ReadJSON();
        }
    }
}

