namespace ILA_Vokabeltrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wort = new string[20];
            string[] übersetzung = new string[20];
            int anzahleingabe = 0;
            Console.WriteLine("Geben sie maximal 20 Wortpaare ein.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            
            

              
            for (int i = 0; i < 20; i++)
            {
                
                
                    Dictionary<int, string> Voki = new Dictionary<int, string>
                {
                 { 1, GetStringFromUser("Geben sie das Wort ein: ") },
                 { 2, GetStringFromUser("Geben sie das übersetzte Wort ein: ") }
                };

                   
                    string GetStringFromUser(string wort)
                    {
                        Console.Write(wort);
                        return Console.ReadLine();
                    }

                    wort[i] = Voki[1];
                    übersetzung[i] = Voki[2];
                    anzahleingabe++;

                if(anzahleingabe == 20)
                {
                    Console.WriteLine("Sie haben das limit von 10 Wortpaaren erreicht");
                    break;
                }


                    Console.Write("Für weiter eingabe drücken sie Enter [Beenden = n] ");
                    string janein = Console.ReadLine().ToLower();

                if (janein == "n")
                {
                    Console.Clear();
                    break;
                    
                }
               



            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            int fehler = 0;
            int korrekt = 0;
            string[] falscheingabe = new string[20];
            string[] wärerichtigso = new string[20];
            int anzahlfehler = 0;
            for (int x = 0; x < anzahleingabe; x++)
            {
                Console.WriteLine("Übersetze: ");
                Console.Write(wort[x] + " ");
                string prüfen = Console.ReadLine().ToLower();
                
                

                if (übersetzung[x] == prüfen)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("RICHTIG!");
                    Console.ResetColor();
                    korrekt++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Leider falsch");
                    Console.ResetColor();
                    fehler++;
                    falscheingabe[x] = wort[x];
                    wärerichtigso[x] = übersetzung[x];
                    anzahlfehler++;
                }
                
                    
                

            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sie haben " + korrekt + " Wörter richtig übersetzt.");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sie haben " + fehler + " Wörter falsch übersetzt: ");
            Console.ResetColor();
            Console.WriteLine();
            for (int x = 0; x <= anzahlfehler; x++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(falscheingabe[x]);
                Console.ResetColor();
            }

            if (anzahlfehler == 0)
            {

            }
            else
            {
                Console.WriteLine("Wollen sie die Lösung für die falsch einegegbenen Wörter sehen? [y|n]");
                string lösung = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (lösung == "y")
                {
                    for (int x = 0; x <= anzahlfehler; x++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(falscheingabe[x] + " = " + wärerichtigso[x]);
                        Console.ResetColor() ;
                    }

                }
                else
                {
                   
                }

                /*Ausgabe der falsch geschriebenen Wörter und der Lösungen zu den falsch geschriebenen Wörter funktioniert nicht
                  richtig, da es in einem array gespeichert wird. Wenn jetzt zb das erst wort falsch ist wird es auf der 0 gespeichert, 
                ist das 2 wort richtig wird es auf der 1 gespeichert, ist dan wiederum das 3 wort falsch wird es auf der 2 gespeichert. 
                Will man nun die falschen Wörter ausgeben, gibt es zwischen den beiden falschen wörter eine Lücke, weil dort auf der "Zeile 1" 
                sozusagen das richtige wort stehen würde, was aber einfach nicht geschrieben wird.*/

            }
        }
    }
}