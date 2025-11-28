using System;

class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hosgeldiniz!";
        string degisken2 = "CSharp";

        // Length
        Console.WriteLine(degisken.Length);

        // ToUpper - ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        // Concat
        Console.WriteLine(String.Concat(degisken, " Merhaba!"));

        // Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1
        Console.WriteLine(String.Compare(degisken, degisken2, true));
        Console.WriteLine(String.Compare(degisken, degisken2, false));

        // Contains
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        // IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("Zikriye"));

        // Insert
        Console.WriteLine(degisken.Insert(0, "Merhaba! "));
        Console.WriteLine(degisken.LastIndexOf("i"));
    }
}