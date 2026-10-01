namespace Aufgabe06;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Das kleine 1x1");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t" );
            }
            Console.WriteLine();
        }
    }
}