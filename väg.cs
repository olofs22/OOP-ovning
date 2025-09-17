

namespace OOP_ovning
{
    //Skapar en klass som heter väg
    public class Väg 

    {
        //Skapar attributer som beskriver klassen
        public string Material;
        public double Längd;
        public int Bredd;
        public int Maxfart;

        //Lägger till en metod som beskriver vad för sorts väg det är gör den virtual så den kan overridas.
        public virtual void VägB()
        {
            Console.WriteLine("Det här är en privat väg");
        }

        
       

    }
}
