using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    internal class KuliahMahasiswa103082400008
    {
        public class mataKuliah
        {
            public string kode { get; set; }
            public String nama { get; set; }
        }
        public class  daftarMatkul
        {
            public List<mataKuliah> listMatkul { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "tpModul7_2_103082400008.json";
            string jsonString = File.ReadAllText(filePath);

            daftarMatkul mkList = JsonSerializer.Deserialize<daftarMatkul>(jsonString);

            Console.WriteLine("daftar mata kuliah yang diambil : ");
            int i = 1;
            foreach (var mk in mkList.listMatkul)
            {
                Console.WriteLine($"MK { i } { mk.kode} - { mk.nama}" );
                    i ++;
            }
        }
    }
}
