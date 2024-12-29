internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç öğrenci kaydetmek istiyorsunuz: ");
        int ogrenciSayisi = int.Parse(Console.ReadLine());

        string[,] ogrenci = new string[ogrenciSayisi, 7];

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine($"{i + 1}. Öğrencinin bilgilerini giriniz:");

            Console.Write("Numarasını giriniz (11 hane): ");
            ogrenci[i, 0] = Console.ReadLine();

            Console.Write("Adını giriniz: ");
            ogrenci[i, 1] = Console.ReadLine();

            Console.Write("Soyadını giriniz: ");
            ogrenci[i, 2] = Console.ReadLine();

            Console.Write("Vize notunu giriniz (0-100): ");
            int vize = int.Parse(Console.ReadLine());
            ogrenci[i, 3] = vize.ToString();

            Console.Write("Final notunu giriniz (0-100): ");
            int final = int.Parse(Console.ReadLine());
            ogrenci[i, 4] = final.ToString();

            double ortalama = (vize * 0.4) + (final * 0.6);
            ogrenci[i, 5] = ortalama.ToString("F2");

            string[] harfNotlari = { "FF", "FD", "DD", "DC", "CC", "CB", "BB", "BA", "AA" };
            int indeks = (int)Math.Min(Math.Max((ortalama - 10) / 10, 0), 8);
            ogrenci[i, 6] = harfNotlari[indeks];
        }

        Console.WriteLine("\nNumara\tAd\tSoyad\tVize Notu\tFinal Notu\tOrtalama\tHarf Notu");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine($"{ogrenci[i, 0]}\t{ogrenci[i, 1]}\t{ogrenci[i, 2]}\t" +
                              $"{ogrenci[i, 3]}\t\t{ogrenci[i, 4]}\t\t{ogrenci[i, 5]}\t\t{ogrenci[i, 6]}");
        }
    }
}