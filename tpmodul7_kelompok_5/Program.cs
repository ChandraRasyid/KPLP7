using System;

namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            dataMahasiswa103082400008 dataMhs = new dataMahasiswa103082400008();
            dataMhs.ReadJSON();

            Console.WriteLine();

            KuliahMahasiswa103082400008 dataKuliah = new KuliahMahasiswa103082400008();
            dataKuliah.ReadJSON();
        }
    }
}