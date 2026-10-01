namespace Aufgabe01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib 2 Zahlen ein:");
        int zahl1 = int.Parse(Console.ReadLine());
        int zahl2 = int.Parse(Console.ReadLine());
        int summe = zahl1 + zahl2;
        Console.WriteLine("Die Summe der Zahlen ist " + summe );
    }
}