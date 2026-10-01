namespace Aufgabe05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie viel Kilometer willst du rennen?");
        double km = double.Parse(Console.ReadLine());

        if (km > 42)
        {
            Console.WriteLine("Das schaffst du nicht!");
        }
        else
        {
            km = km * 1000;
            double n = km / 400;
            Console.WriteLine("Das sind " + n + " Runden. Bereit für den Lauf? 1 = ja, 2 = nein");
            int antwort = int.Parse(Console.ReadLine());
            switch (antwort)
            {
                case 1:
                    int i = 1;
                    while (i <= n)
                    {
                        Console.WriteLine("Du läufst Runde " + i);
                        i++;
                    }
                    Console.WriteLine("Du hast es geschafft!");
                    break;
                case 2 :
                    break;
                default:
                    break;
            }


        }
    }
}