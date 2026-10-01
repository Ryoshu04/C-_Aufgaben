namespace Aufgabe14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prüfen, ob es sich bei einem Jahr oder um ein Schaltjahr handelt");
        
        while(true)
        {           Console.WriteLine("Eingabe Jahr (q to quit): ");
            string input = Console.ReadLine();
            if (input == "q")
                break;

            int year = Convert.ToInt32(input);
            CheckSchaltjahr(year);
        }
        
        Console.WriteLine("Programm beendet");
    }

    private static void CheckSchaltjahr(int year)
    {
        if (year % 4 == 0 && year % 100 != 0) 
        {
            
            Console.WriteLine("Das Jahr " + year + " ist ein Schaltjahr");
        }
        else if(year % 400 == 0)
        {
            Console.WriteLine("Das Jahr " + year + " ist ein Schaltjahr");
        }
        else
        {
            Console.WriteLine("Das Jahr " + year + " ist kein Schaltjahr");
        }
    }
}