
namespace OOP_ovning
{
    //Ny klass med känslig information om vart polisen ska ha fartkontroller varjedag
    public class Polisspan
    {
        //En string för varje dag
        private string PlatsMåndag;
        private string PlatsTisdag;
        private string PlatsOnsdag;
        private string PlatsTorsdag;
        private string PlatsFredag;

        //Dags att sätta värden på dessa och det gör vi i denna filen eftersom dessa är privata attribut.
        public void SetMåndag()
        {
            PlatsMåndag = "Redegatan 1H";
        }
        public void SetTisdag()
        {
            PlatsTisdag = "Södra Hamngatan 2";
        }

        public void SetOnsdag()
        {
            PlatsOnsdag = "Västra Hamngatan 5b";
        }

        public void SetTorsdag()
        {
            PlatsTorsdag = "Östra Hamngatan 56";
        }

        public void SetFredag()
        {
            PlatsFredag = "Norra Hamngatan 53E";
        }

        //En metod som skriver ut att användaren inte har åtkomskt till viss information
        public void EjÅtkomstMeddelande()
        {
            Console.WriteLine("Hej denna informationen kommer inte du åt :)");
        }

    }
    
}
