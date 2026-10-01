namespace Aufgabe07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zahlen zwischen 1 & 30, die durch 5 und/ oder 3 ohne Rest teilbar sind:");
        int i = 1;
        while (i <= 30)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.Write(i + ", ");
            }
            i++;
        }
    }
}