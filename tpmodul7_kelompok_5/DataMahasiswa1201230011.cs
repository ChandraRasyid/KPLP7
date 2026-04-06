using System;
using System.IO;
using System.Text.Json;

class DataMahasiswa1201230011
{
    public Nama? nama { get; set; }
    public int nim { get; set; }
    public string? fakultas { get; set; }

    public class Nama
    {
        public string? depan { get; set; }
        public string? belakang { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_1201230011.json");

        DataMahasiswa1201230011 data = JsonSerializer.Deserialize<DataMahasiswa1201230011>(jsonString)!;

        Console.WriteLine(
            $"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}"
        );

    }
}