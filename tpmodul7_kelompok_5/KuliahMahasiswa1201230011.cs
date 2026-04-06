using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class KuliahMahasiswa1201230011
{
    public List<MataKuliah>? mata_kuliah { get; set; }

    public class MataKuliah
    {
        public string? kode { get; set; }
        public string? nama { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_1201230011.json");

        KuliahMahasiswa1201230011 data = JsonSerializer.Deserialize<KuliahMahasiswa1201230011>(jsonString)!;

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        int i = 1;
        foreach (var mk in data.mata_kuliah)
        {
            Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
            i++;
        }
    }
}