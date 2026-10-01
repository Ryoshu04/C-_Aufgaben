namespace Aufgabe13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie lange soll die Linie sein?");
        int zahl = int.Parse(Console.ReadLine());

        int runde = 0;
        int abstand = 0;

        zeichneLinie(zahl, runde, abstand);
    }

    private static void zeichneLinie(int zahl, int runde, int abstand)
    {
        for (int i = 0; i < zahl ; i++)
        {
            for (int j = 1; j < zahl; j++)
            {
                if (runde == abstand)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                abstand++;
            }
            Console.WriteLine();
            runde++;
            abstand = 0;
        }
    }
}