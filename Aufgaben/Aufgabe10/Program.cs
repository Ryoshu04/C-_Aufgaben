namespace Aufgabe10;

class Program
{
    static void Main(string[] args)
    {

        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;
            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }
            return sum;
        }

        Console.WriteLine("Gib eine Zahl ein");
        int i = int.Parse(Console.ReadLine());
        int result = BerechneQuersumme(i);
        Console.WriteLine("Das resultat ist " + result);
    }
}