namespace OOP_ovning
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Skapar ett objekt av klassen väg
            Väg Väg1 = new Väg();
            //Definierar attributerna hos väg
            Väg1.Bredd = 6;
            Väg1.Längd = 3.4;
            Väg1.Material = "grus-";
            Väg1.Maxfart = 50;

            //Skriver ut attributerna fär Väg i consolen
            Console.WriteLine($"Det här är en {Väg1.Material}väg som sträcker sig {Väg1.Längd} kilometer, den är {Väg1.Bredd} meter bred och har en maxfart på {Väg1.Maxfart}.");

            //Skapar ett objekta av Väg2 som är en subklass av klassen Väg
            Väg Väg2 = new Väg();
            //Definierar attributerna hos väg2
            Väg2.Bredd = 21;
            Väg2.Längd = 321;
            Väg2.Material = "asfalts-";
            Väg2.Maxfart = 120;

            //Skriver ut attributerna för Väg2 i consolen
            Console.WriteLine($"Det här är en {Väg2.Material}väg som sträcker sig {Väg2.Längd} mil, den är {Väg2.Bredd} meter bred och har en maxfart på {Väg2.Maxfart}.");

            //Skapar ett nytt objekt av klassen Polisspan
            Polisspan Span = new Polisspan();

            //Skriver ut ett meddelande som förklarar att det finns information användaren inte kommer åt
            Span.EjÅtkomstMeddelande();

        }
    }
}
