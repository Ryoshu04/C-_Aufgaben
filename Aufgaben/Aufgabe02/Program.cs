namespace Aufgabe02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gebe an, wie viele Tagen dein Monat hat");
        int monatTage = int.Parse(Console.ReadLine());
        if (monatTage > 27 && monatTage < 31)
        {
            int sekunden = monatTage * 86400;
            Console.WriteLine("Ein Monat mit " + monatTage + " Tagen hat "  + sekunden + " Sekunden");
        }
        else
        {
            Console.WriteLine("Keine Monat hat " + monatTage + " Tagen");
        }

    }
}