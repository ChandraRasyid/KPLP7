using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    public class DataMahasiswa_103082400003
    {
        public string nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string filename = "data_mahasiswa_103082400003.json";
            string jsonString = File.ReadAllText(filename);

            DataMahasiswa_103082400003 dm = JsonSerializer.Deserialize<DataMahasiswa_103082400003>(jsonString);
            Console.WriteLine($"Nama : {dm.nama} dengan NIM : {dm.nim} dari fakultas : {dm.fakultas}");
        }
    }
}
