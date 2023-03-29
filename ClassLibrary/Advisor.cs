namespace ClassLibrary
{
    internal class Advisor : ILvlAccess
    {
        public string Position { get; set; }
        public string Posibilities { get; set; }

        public Advisor() : base()
        { Position = "advisor"; Posibilities = "Может просматривать и менять только часть информации"; }


    }
}
