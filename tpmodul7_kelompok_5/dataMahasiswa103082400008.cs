using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    internal class dataMahasiswa103082400008
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }

        }
        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }

        }
        public void ReadJSON()
        {
            string filePath = "tpModul7_1_103082400008.json";
            string jsonString = File.ReadAllText(filePath);

            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} denghan nim {mhs.nim} fakultas {mhs.fakultas}");
        }
    }
}
