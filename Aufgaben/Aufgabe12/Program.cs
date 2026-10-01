namespace Aufgabe12;

class Program
{
    static void Main(string[] args)
    {
        static int[] SumUp(int[] arr)
        {
            int[] result = new int[arr.Length];
            result[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = result[i - 1] + arr[i];
            }
            return result;
        }
        Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Kommas getrennt ein:");
        string eingabe = Console.ReadLine();
        string[] eingabeArray  = eingabe.Split(',');
        int[] eingabeArrayInt = Array.ConvertAll(eingabeArray, int.Parse);

        Console.WriteLine("Resultat: ");
        for (int i = 0; i < SumUp(eingabeArrayInt).Length; i++)
        {
            Console.Write($"[{i}] --> ");
            Console.Write($"{SumUp(eingabeArrayInt)[i]}\t");
        }
        
    }
}