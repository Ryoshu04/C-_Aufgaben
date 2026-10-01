namespace Aufgaben;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Gib eine Zahl, die zu Binärzahl umgewandelt soll");
         int n = int.Parse(Console.ReadLine());
        
            int rest = n % 2;
            
        Console.WriteLine(rest);
    }
}