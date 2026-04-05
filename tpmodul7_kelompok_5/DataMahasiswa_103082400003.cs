using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa_103082400003
    {
        public NamaMahasiswa nama { get; set; }
        //public string nama_depan { get; set; }
        //public string nama_belakang { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string filename = "tp7_1_103082400003.json";
            string jsonString = File.ReadAllText(filename);

            DataMahasiswa_103082400003 dm = JsonSerializer.Deserialize<DataMahasiswa_103082400003>(jsonString);
            Console.WriteLine($"Nama : {dm.nama.depan} {dm.nama.belakang} dengan NIM : {dm.nim} dari fakultas : {dm.fakultas}");
        }
    }
}
