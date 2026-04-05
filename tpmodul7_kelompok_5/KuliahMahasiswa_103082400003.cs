using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class KuliahMahasiswa_103082400003
    {
        public MataKuliah[] courses { get; set; }

        public void ReadJSON()
        {
            string filename = "tp7_2_103082400003.json";
            string jsonString = File.ReadAllText(filename);

            KuliahMahasiswa_103082400003 km = JsonSerializer.Deserialize<KuliahMahasiswa_103082400003>(jsonString);

            Console.WriteLine("Mata Kuliah yang diambil : ");
            for (int i = 0; i < km.courses.Length; i++)
            {
                Console.WriteLine($"MK {i+1} {km.courses[i].code} - {km.courses[i].name}");
            }
        }
    }
}
