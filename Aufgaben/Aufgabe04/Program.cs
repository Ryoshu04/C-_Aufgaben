namespace Aufgabe04;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Gib eine Zahl zwischen 1 bis 12 ein");
        int monatZahl = int.Parse(Console.ReadLine());
        switch (monatZahl)
        {
            case 1:
                Console.WriteLine("Dein Monat ist Januar");
                break;
            case 2:
                Console.WriteLine("Dein Monat ist Februar");
                break;
            case 3:
                Console.WriteLine("Dein Monat ist März");
                break;
            case 4:
                Console.WriteLine("Dein Monat ist April");
                break;
            case 5:
                Console.WriteLine("Dein Monat ist Mai");
                break;
            case 6:
                Console.WriteLine("Dein Monat ist Juni");
                break;
            case 7:
                Console.WriteLine("Dein Monat ist Juli");
                break;
            case 8:
                Console.WriteLine("Dein Monat ist August");
                break;
            case 9:
                Console.WriteLine("Dein Monat ist September");
                break;
            case 10:
                Console.WriteLine("Dein Monat ist Oktober");
                break;
            case 11:
                Console.WriteLine("Dein Monat ist November");
                break;
            case 12:
                Console.WriteLine("Dein Monat ist Dezember");
                break;
            default:
                Console.WriteLine(monatZahl + " ist kein Option!");
                break;
        }

    }
}