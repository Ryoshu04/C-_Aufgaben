namespace Aufgabe09;

class Program
{
    static void Main(string[] args)
    {
        string bin = "";
        string quit = "q";
        bool weiter =true;
         while (weiter) {
            Console.WriteLine("Gib eine Zahl, die zu Binärzahl umgewandelt soll (q to Quit)");
            
                    string m = Console.ReadLine();
                    if (m !="q")
                    {
                   
                        int n = Convert.ToInt32(m);
                        Console.WriteLine(m);
                            do
                            {
                                int rest = n % 2;
                                bin = rest + bin;
                                int wert = n / 2;
                                n = wert;
                            } while (n != 0);

                            Console.WriteLine(bin);
                            bin = "";
                    }
                    else
                    {
                        weiter = false;
                        Console.WriteLine("Programm beendet");
                    }
         }
    }
}