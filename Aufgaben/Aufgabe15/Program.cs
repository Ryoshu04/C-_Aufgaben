namespace Aufgabe15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie breit soll der Stamm sein?");
        int stammBreite = int.Parse(Console.ReadLine());
        Console.WriteLine("Wie hoch soll der Stamm sein?");
        int stammHoch = int.Parse(Console.ReadLine());
        Console.WriteLine("Wie hoch soll die Krone sein?");
        int kroneHoch = int.Parse(Console.ReadLine());
        
        krone(kroneHoch);
        stamm(stammBreite, stammHoch, kroneHoch);
        
    }

    private static void stamm(int stammBreite, int stammHoch, int kroneHoch)
    {
        for (int i = 0; i < stammHoch;i++)
        {
            int abstandStamm = kroneHoch / 2 ;

            for (int n = 0; n <= abstandStamm; n++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < stammBreite; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
    private static void krone(int kroneHoch)
    {
        int runde = 1;
        int abstandKrone = kroneHoch - 1;
        
        for (int k = 0; k < kroneHoch; k++)
        {
            for (int m = 1; m <= abstandKrone; m++)
            {
                Console.Write(" ");
            }
            for (int l = 1; l <= runde; l++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            runde = runde + 2;
            abstandKrone = abstandKrone - 1;
        }
    }
}