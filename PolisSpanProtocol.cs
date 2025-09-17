

namespace OOP_ovning
{
    //Gjorde en ny huvudklass för polisspan som är ett protocol, det ser till att ett ej åtkomst meddelande visas om användaren inte kommer åt känslig information.
    //Abstract klass typ
    public abstract class PolisSpanProtocol
    {
        public abstract void EjÅtkomstMeddelande();
    }
}
