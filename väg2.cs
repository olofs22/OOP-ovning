
namespace OOP_ovning
{
    //Skapar en ny klass som är en subklass av "Väg"
    public class Väg2 : Väg
    {
            //Tar den förra metoden och overridar den
            public override void VägB()
            {
                Console.WriteLine("Det här är en allmän väg");
            }

        }

  }
