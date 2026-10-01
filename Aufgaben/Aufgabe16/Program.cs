namespace Aufgabe16;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random randomNum = new Random();
            int random = randomNum.Next(1, 100);
            Console.WriteLine("Wähle ein Zahl zwischen 1 bis 100");
            int number = int.Parse(Console.ReadLine());
            int tries = 0;

            while (number != random)
            {
                tries++;
                if (number < random)
                {Console.WriteLine("Zahl ist zu klein");}
            
                if (number > random)
                {Console.WriteLine("Zahl ist zu gross");}
            
                Console.WriteLine("Gib noch ein Zahl ein: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Du hast es geschafft!!!!!! Gratulation!!!!");
            Console.WriteLine("Du hast " + tries + " Versuche gebraucht.");
            Console.WriteLine("Willst du noch mal? Ja = y, Nein = n");
            string input = Console.ReadLine();
            string answer = input.ToLower();

            if (answer == "n")
            {
                break;
            }
        }

    }
}