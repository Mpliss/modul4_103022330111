using System;

public class kodeProduk
{
    public static string getKodeProduk(string produk)
    {
        string[,] dataKodeProduk =
        {
            {"Laptop", "E100" },
            {"Smartphone", "E101" },
            {"Tablet", "E102" },
            {"Headset", "E103" },
            {"Keyboard", "E104" },
            {"Mouse", "E105" },
            {"Printer", "E106" },
            {"Monitor", "E107" },
            {"Smartwatch", "E108" },
            {"kamera", "E109" }
        };

        for (int i = 0; i < dataKodeProduk.GetLength(0); i++)
        {
            if (dataKodeProduk[i, 0].Equals(produk, StringComparison.OrdinalIgnoreCase))
            {
                return dataKodeProduk[i, 1];
            }
        }
        return "Kode produk tidak ditemukan";
    }
}

//public class FunLaptop


public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. Program kode Produk");
        Console.WriteLine("2. Program edit Fan Laptop");
        Console.WriteLine("0. Exit");
        Console.WriteLine("Masukan pilihan: ");

        String masuk = Console.ReadLine();

        while(masuk != "0")
        {
            if (masuk == "1")
            {
                kodeProduk Kode = new kodeProduk();
                Console.WriteLine("Masukan nama produk: ");
                string produk = Console.ReadLine() ?? "";

                if (produk != "kembali")
                {
                    string kode = kodeProduk.getKodeProduk(produk);
                    Console.WriteLine($"Kode produk {produk} : {kode}");
                }
                else
                {
                    Main();
                }
            }else if (masuk == "0")
            {
                break;
            }
        }
    }
}