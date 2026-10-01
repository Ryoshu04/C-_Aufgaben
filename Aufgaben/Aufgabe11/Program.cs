namespace Aufgabe11;

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
        
        Console.WriteLine("Zahl 1:");
        int zahl1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Zahl 2:");
        int zahl2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("---------------------------------");
        Console.Write("Zahl");
        Console.Write("| Quersumme ");
        Console.WriteLine("|Zahl/ Quersumme ");
        Console.WriteLine("---------------------------------");
        for (int i = zahl1; zahl1 <= zahl2; zahl1++)
        {int result = BerechneQuersumme(zahl1);
            for (int j = 0; j <= 0;   j++)
            {
                if (zahl1 % result == 0)
                {
                    Console.Write($"{zahl1}\t");
                    Console.Write($"{"|" +result}\t");
                    Console.Write($"{"|" + zahl1 / result}\t");
                    Console.WriteLine();
                }
            }
        }
    }
}