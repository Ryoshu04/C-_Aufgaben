namespace Aufgaben08;

class Program
{
    static void Main(string[] args)
    {
        int anzahl = 0;
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" , "shit"};
        Console.WriteLine("Dein Kommentar");
        string kommentar = Console.ReadLine();
        string k = kommentar.ToLower();

        for(int i = 0; i < forbiddenWords.Length; i++)
        {
            if (k.Contains(forbiddenWords[i]))
            {
                anzahl = anzahl + 1;
            }
        }
        if (anzahl == 0)
        {
            Console.WriteLine("Vielen dank für deinen Kommentar");
        }
        else
        { 
            Console.WriteLine("Dein Kommentar enthält "+anzahl + " verbotene Wörter. Es wird nicht veröffentlicht");
        }
    }
}